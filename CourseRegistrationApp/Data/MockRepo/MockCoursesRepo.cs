using CourseRegistrationApp.Data.Interfaces;
using CourseRegistrationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Data.MockRepo
{
    public class MockCoursesRepo : ICoursesRepo
    {
        private readonly static List<Courses> _courses = new List<Courses>
        {
            new Courses { C_CourseId = 101, C_CourseNumber = 2400, C_CourseName = "Homeopathy", C_CourseDescrip = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."},
            new Courses { C_CourseId = 102, C_CourseNumber = 2410, C_CourseName = "Astrology", C_CourseDescrip = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."},
            new Courses { C_CourseId = 103, C_CourseNumber = 2420, C_CourseName = "Programming", C_CourseDescrip = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."},
            new Courses { C_CourseId = 104, C_CourseNumber = 2430, C_CourseName = "Mathematics", C_CourseDescrip = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."}
        };
        public IEnumerable<Courses> GetAllCourses()
        {
            return _courses;
        }
    }
}
