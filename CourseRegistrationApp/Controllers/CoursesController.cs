using CourseRegistrationApp.Data.Interfaces;
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

        public CoursesController(ICoursesRepo coursesRepo)
        {
            _coursesRepo = coursesRepo;
        }
        public IActionResult Index()
        {
            return View(_coursesRepo.GetAllCourses());
        }
    }
}
