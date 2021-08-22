using CourseRegistrationApp.Data.Interfaces;
using CourseRegistrationApp.Models;
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

        public CoursesController(ICoursesRepo coursesRepo, IStudentRepo studentsRepo)
        {
            _coursesRepo = coursesRepo;
            _studentRepo = studentsRepo;
        }
        public IActionResult Index()
        {
            var students = _studentRepo.GetAllStudents();
            var list = _coursesRepo.GetAllCourses()
                .Select(c =>
                {
                    c.Students = students
                                    .Where(s => s.C_CourseId == c.C_CourseId)
                                    .FirstOrDefault() ?? new Students
                                    {
                                        S_FirstName = "n/a"
                                    };
                    return c;
                })

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
        public ActionResult Create(Courses input)
        {
            _coursesRepo.CreateCourse(input);
            _coursesRepo.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Edit(int id)
        {
            var courseToEdit = _coursesRepo.GetCourseById(id);
            return View(courseToEdit);
        }

        [HttpPost]
        public ActionResult Edit(Courses course)
        {
            try
            {
                _coursesRepo.UpdateCourse(course);
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
            return View(_coursesRepo.GetCourseById(id));
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
