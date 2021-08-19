using CourseRegistrationApp.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Controllers
{
    public class InstructorsController : Controller
    {
        private readonly IInstructorsRepo _instructorsRepo;
        private readonly ICoursesRepo _coursesRepo;

        public InstructorsController(IInstructorsRepo instRepo, ICoursesRepo courseRepo)
        {
            _instructorsRepo = instRepo;
            _coursesRepo = courseRepo;
        }
        public IActionResult Index()
        {

            var courses = _coursesRepo.GetAllCourses();
            var list = _instructorsRepo.GetAllInstructors()
                .Select(i =>
                {
                    i.Course = courses.Where(c => c.C_CourseId == i.C_CourseId)
                                      .FirstOrDefault();
                    return i;
                })
                .ToList();
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}
