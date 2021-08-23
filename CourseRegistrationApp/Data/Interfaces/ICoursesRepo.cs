using CourseRegistrationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Data.Interfaces
{
    public interface ICoursesRepo
    {
        IEnumerable<Course> GetAllCourses();
        Course GetCourseById(int id);
        void CreateCourse(Course input);
        void UpdateCourse(Course input);
        void DeleteCourse(int id);
        bool SaveChanges();
    }
}
