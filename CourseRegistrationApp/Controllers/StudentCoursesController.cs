using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Controllers
{
    public class StudentCoursesController : Controller
    {
        // GET: StudentCoursesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StudentCoursesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentCoursesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentCoursesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentCoursesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentCoursesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentCoursesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentCoursesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
