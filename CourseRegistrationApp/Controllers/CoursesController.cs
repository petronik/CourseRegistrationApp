using CourseRegistrationApp.Data;
using CourseRegistrationApp.Data.Interfaces;
using CourseRegistrationApp.Models;
using CourseRegistrationApp.ModelsDto;
using CourseRegistrationApp.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICoursesRepo _coursesRepo;
        private readonly IStudentRepo _studentRepo;
        private readonly IStudentCoursesRepo _studentCoursesRepo;
        private readonly Mapper _mapper = new Mapper();

        public CoursesController(ICoursesRepo coursesRepo, IStudentRepo studentsRepo, IStudentCoursesRepo studentCoursesRepo)
        {
            _coursesRepo = coursesRepo;
            _studentRepo = studentsRepo;
            _studentCoursesRepo = studentCoursesRepo;
        }
        public ActionResult Index()
        {
            var list = _coursesRepo.GetAllCourses()
                        .Select(c => _mapper.Map(c))
                        .ToList();
            return View(list);
        }
        //public IEnumerable<string> GetStudentsByCourse(int? id)
        //{
        //    var res = _studentRepo.GetAllStudents()
        //                           .Select(s => s.S_FirstName + " " + s.S_LastName + "<br>");
        //    if (res == null || res.Count() == 0)
        //    {
        //        return new List<string> { "No Students On This Course." };
        //    }

        //    return res;
        //}

        public ActionResult GetStudentsByCourseId(int id)
        {
            var courseStudent = _studentCoursesRepo.GetAllStudentCourses();
            var students = _studentRepo.GetAllStudents()
                .Select(s =>
                    new StudentVM
                    {
                        Id = s.S_Id,
                        FirstName = s.S_FirstName,
                        LastName = s.S_LastName,
                        IsActive = courseStudent
                        .Where(cs => cs.StudentId == s.S_Id &&
                            cs.CourseId == id)
                        .FirstOrDefault() == null ? false : true
                    }
                )
                .ToList();

            SaveStudentsInCourseVM pvm = new SaveStudentsInCourseVM
            {
                Student = students,
                CourseId = id
            };
            
            return PartialView(pvm);
        }

        public ActionResult SaveStudents(SaveStudentsInCourseVM obj)
        {
            _studentCoursesRepo.RemoveRange(obj.CourseId);
            var rangeToAdd = obj.Student
                .Where(s => s.IsActive)
                .Select(sc => new StudentCourse
                {
                    CourseId = obj.CourseId,
                    StudentId = sc.Id
                });

            _studentCoursesRepo.AddRange(rangeToAdd);
            _studentCoursesRepo.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CourseDto input)
        {
            _coursesRepo.CreateCourse(_mapper.Map(input));
            _coursesRepo.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Edit(int id)
        {
            var courseToEdit = _mapper.Map(_coursesRepo.GetCourseById(id));
            return View(courseToEdit);
        }

        [HttpPost]
        public ActionResult Edit(CourseDto course)
        {
            try
            {
                _coursesRepo.UpdateCourse(_mapper.Map(course));
                _coursesRepo.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View(_mapper.Map(_coursesRepo.GetCourseById(id)));
        }

        [HttpPost]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _coursesRepo.DeleteCourse(id);
                _coursesRepo.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
