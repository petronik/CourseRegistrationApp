using CourseRegistrationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Data.Interfaces
{
    public interface IStudentCoursesRepo
    {
        IEnumerable<StudentCourse> GetAllStudentCourses();
        StudentCourse GetStudentCourseById(int id);
        void CreateStudentCourse(StudentCourse input);
        void UpdateStudentCourse(StudentCourse input);
        void DeleteStudentCourse(int id);
        bool SaveChanges();
        void RemoveRange(int courseId);
        void AddRange(IEnumerable<StudentCourse> range);
    }
}
