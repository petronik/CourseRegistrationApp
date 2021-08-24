using CourseRegistrationApp.Data.Interfaces;
using CourseRegistrationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Data.SqlRepo
{
    public class SqlStudentCoursesRepo : IStudentCoursesRepo
    {
        private readonly AppDbContext _context;

        public SqlStudentCoursesRepo(AppDbContext context)
        {
            _context = context;
        }
        public void CreateStudentCourse(StudentCourse input)
        {
            throw new NotImplementedException();
        }

        public void DeleteStudentCourse(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StudentCourse> GetAllStudentCourses()
        {
            return _context.StudentCourses.ToList();
        }

        public StudentCourse GetStudentCourseById(int id)
        {
            return _context.StudentCourses.FirstOrDefault(sc => sc.Id == id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UpdateStudentCourse(StudentCourse input)
        {
            throw new NotImplementedException();
        }
    }
}
