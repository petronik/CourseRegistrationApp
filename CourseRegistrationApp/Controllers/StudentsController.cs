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
            var list = _studentRepo.GetAllStudents().ToList();
            return View(list);
        }

        public ActionResult Create()
        {
            ViewBag.Courses = 
                new SelectList(_courseRepo.GetAllCourses().ToList(),
                                "C_CourseId", "C_CourseName"
                                );
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            _studentRepo.CreateStudent(student);
            return RedirectToAction(nameof(Index));
        }
    }

}
