using CourseRegistrationApp.Data;
using CourseRegistrationApp.Data.Interfaces;
using CourseRegistrationApp.Models;
using CourseRegistrationApp.ModelsDto;
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
        private readonly Mapper _mapper = new Mapper();
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
                .Select(i => _mapper.Map(i))
                .ToList();
            return View(list);
        }

        public ActionResult Create()
        {
            var list = _coursesRepo.GetAllCourses()
                .Select(c => _mapper.Map(c))
                .ToList();
            ViewBag.Courses = new SelectList(list,
                                "C_CourseId", "C_CourseName"
                                );
            return View();
        }

        [HttpPost]
        public ActionResult Create(InstructorDto instructor)
        {
            _instructorsRepo.CreateInstructor(_mapper.Map(instructor));
            _instructorsRepo.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            var list = _coursesRepo.GetAllCourses()
                .Select(c => _mapper.Map(c))
                .ToList();
            ViewBag.Courses = new SelectList(list, "C_CourseId", "C_CourseName");

            var instructorToEdit = _mapper.Map(_instructorsRepo.GetInstructorById(id));
            return View(instructorToEdit);
        }

        [HttpPost]
        public ActionResult Edit(InstructorDto instructor)
        {
            try
            {
                _instructorsRepo.UpdateInstructor(_mapper.Map(instructor));
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
            return View(_mapper.Map(_instructorsRepo.GetInstructorById(id)));
        }

        [HttpPost]
        public ActionResult Delete(Instructor input)
        {
            try
            {
                _instructorsRepo.DeleteInstructor(input.I_Id);
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
