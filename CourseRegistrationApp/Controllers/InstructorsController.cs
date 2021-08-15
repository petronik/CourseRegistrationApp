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

        public InstructorsController(IInstructorsRepo instRepo)
        {
            _instructorsRepo = instRepo;
        }
        public IActionResult Index()
        {
            return View(_instructorsRepo.GetAllInstructors());
        }
    }
}
