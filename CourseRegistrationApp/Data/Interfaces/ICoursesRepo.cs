using CourseRegistrationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Data.Interfaces
{
    public interface ICoursesRepo
    {
        IEnumerable<Courses> GetAllCourses();
        Courses GetCourseById(int id);
        void CreateCourse(Courses input);
        void UpdateCourse(Courses input);
        void DeleteCourse(int id);
        bool SaveChanges();
    }
}
