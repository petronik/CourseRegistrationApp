using CourseRegistrationApp.Data.Interfaces;
using CourseRegistrationApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentRepo _studentRepo;
        private readonly ICoursesRepo _courseRepo;

        public StudentsController(IStudentRepo studRepo, ICoursesRepo coursesRepo)
        {
            _studentRepo = studRepo;
            _courseRepo = coursesRepo;
        }
        public ActionResult Index()
        {
            var courses = _courseRepo.GetAllCourses();
            var list = _studentRepo.GetAllStudents()
                .Select(s =>
                {
                    s.Course = courses.Where(c => c.C_CourseId == s.C_CourseId)
                                      .FirstOrDefault() ?? new Courses
                                      {
                                          C_CourseName = "N/A"
                                      };
                    return s;
                })
                .ToList();
            return View(list);
        }

        public ActionResult Create()
        {
            var list = _courseRepo.GetAllCourses().ToList();
            ViewBag.Courses = new SelectList(list, "C_CourseId", "C_CourseName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Students student)
        {
            _studentRepo.CreateStudent(student);
            _studentRepo.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            var list2 = _courseRepo.GetAllCourses().ToList();
            ViewBag.Courses = new SelectList(list2, "C_CourseId", "C_CourseName");
            
            var studentToEdit = _studentRepo.GetStudentById(id);
            return View(studentToEdit);
        }
        [HttpPost]
        public ActionResult Edit(Students student)
        {
            try
            {
                _studentRepo.UpdateStudent(student);
                _studentRepo.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View(_studentRepo.GetStudentById(id));
        }

        [HttpPost]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _studentRepo.DeleteStudent(id);
                _studentRepo.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }

}
