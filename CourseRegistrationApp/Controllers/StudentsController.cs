using CourseRegistrationApp.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public StudentsController(IStudentRepo studRepo, ICoursesRepo coursRepo)
        {
            _studentRepo = studRepo;
            _courseRepo = coursRepo;
        }
        public ActionResult Index()
        {
            var course = _courseRepo.GetAllCourses();
            var list = _studentRepo.GetAllStudents().ToList();
            return View(list);
        }
    }
}
