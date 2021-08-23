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
            ViewBag.Courses = new SelectList(_coursesRepo.GetAllCourses().ToList(),
                                "C_CourseId", "C_CourseName"
                                );
            return View();
        }

        [HttpPost]
        public ActionResult Create(Instructor instructor)
        {
            _instructorsRepo.CreateInstructor(instructor);
            _instructorsRepo.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            var list = _coursesRepo.GetAllCourses().ToList();
            ViewBag.Courses = new SelectList(list, "C_CourseId", "C_CourseName");

            var instructorToEdit = _instructorsRepo.GetInstructorById(id);
            return View(instructorToEdit);
        }

        [HttpPost]
        public ActionResult Edit(Instructor instructor)
        {
            try
            {
                _instructorsRepo.UpdateInstructor(instructor);
                _instructorsRepo.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View(_instructorsRepo.GetInstructorById(id));
        }

        [HttpPost]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _instructorsRepo.DeleteInstructor(id);
                _instructorsRepo.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
