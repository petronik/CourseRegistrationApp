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
    public class StudentsController : Controller
    {
        private readonly IStudentRepo _studentRepo;
        private readonly ICoursesRepo _courseRepo;
        private readonly Mapper _mapper = new Mapper();

        public StudentsController(IStudentRepo studRepo, ICoursesRepo coursesRepo)
        {
            _studentRepo = studRepo;
            _courseRepo = coursesRepo;
        }
        public ActionResult Index()
        {
            var courses = _courseRepo.GetAllCourses();
            var list = _studentRepo.GetAllStudents()
                .Select(s => _mapper.Map(s))
                .ToList();
            return View(list);
        }

        public ActionResult Create()
        {
            var list = _courseRepo.GetAllCourses()
                .Select(s => _mapper.Map(s))
                .ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentDto student)
        {
            _studentRepo.CreateStudent(_mapper.Map(student));
            _studentRepo.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            var list2 = _courseRepo.GetAllCourses()
                .Select(c => _mapper.Map(c))
                .ToList();
            
            var studentToEdit = _mapper.Map(_studentRepo.GetStudentById(id));
            return View(studentToEdit);
        }
        [HttpPost]
        public ActionResult Edit(StudentDto student)
        {
            try
            {
                _studentRepo.UpdateStudent(_mapper.Map(student));
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
            return View(_mapper.Map(_studentRepo.GetStudentById(id)));
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
