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
                    c.Students = students.Where(s => s.C_CourseId == c.C_CourseId)
                                            .FirstOrDefault();
                    return c;
                })

                .ToList();
            return View(list);
        }
    }
}
