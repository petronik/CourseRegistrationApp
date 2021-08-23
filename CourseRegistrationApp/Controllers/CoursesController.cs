using CourseRegistrationApp.Data;
using CourseRegistrationApp.Data.Interfaces;
using CourseRegistrationApp.Models;
using CourseRegistrationApp.ModelsDto;
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
        private readonly Mapper _mapper = new Mapper();

        public CoursesController(ICoursesRepo coursesRepo, IStudentRepo studentsRepo)
        {
            _coursesRepo = coursesRepo;
            _studentRepo = studentsRepo;
        }
        public IActionResult Index()
        {
            var list = _coursesRepo.GetAllCourses()
                        .Select(c => _mapper.Map(c))
                        .ToList();
            return View(list);
        }
        public IEnumerable<string> GetStudentsByCourseId(int? id)
        {
            var res = _studentRepo.GetAllStudents()
                                   .Where(s => s.C_CourseId == id)
                                   .Select(s => s.S_FirstName + " " + s.S_LastName + "<br>");
            if(res == null || res.Count() == 0)
            {
                return new List<string> { "No Students On This Course." };
            }

            return res;
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
