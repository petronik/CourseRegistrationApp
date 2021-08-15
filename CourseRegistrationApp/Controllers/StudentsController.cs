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

        public StudentsController(IStudentRepo studRepo)
        {
            _studentRepo = studRepo;
        }
        public ActionResult Index()
        {
            var list = _studentRepo.GetAllStudents();
            return View(list);
        }
    }
}
