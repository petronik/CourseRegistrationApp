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
            throw new NotImplementedException();
        }

        public IEnumerable<Courses> GetAllCourses()
        {
            return _context.Courses.ToList();
        }

        public Courses GetCourseById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UpdateCourse(Courses input)
        {
            throw new NotImplementedException();
        }
    }
}
