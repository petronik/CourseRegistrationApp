using CourseRegistrationApp.Data.Interfaces;
using CourseRegistrationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Data.SqlRepo
{
    public class SqlCoursesRepo : ICoursesRepo
    {
        private readonly AppDbContext _context;

        public SqlCoursesRepo(AppDbContext context)
        {
            _context = context;
        }
        public void CreateCourse(Courses input)
        {
            if(input == null)
            throw new ArgumentException(nameof(input));

            _context.Courses.Add(input);
        }

        public void DeleteCourse(int id)
        {
            var courseToDelete = GetCourseById(id);
            if(courseToDelete != null)
            _context.Courses.Remove(courseToDelete);
        }

        public IEnumerable<Courses> GetAllCourses()
        {
            return _context.Courses.ToList();
        }

        public Courses GetCourseById(int id)
        {
            return _context.Courses.FirstOrDefault(c => c.C_CourseId == id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UpdateCourse(Courses input)
        {
            var courseInTheList = _context.Courses
                .FirstOrDefault(c => c.C_CourseId == input.C_CourseId);

            if (courseInTheList != null)
            {
                courseInTheList.C_CourseNumber = input.C_CourseNumber;
                courseInTheList.C_CourseName = input.C_CourseName;
                courseInTheList.C_CourseDescrip = input.C_CourseDescrip;
            }
        }
    }
}
