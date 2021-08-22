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

        

        public void CreateCourse(Courses input)
        {
            int code = _courses.Max(c => c.C_CourseId) + 1;
            input.C_CourseId = code;
            _courses.Add(input);
        }

        public void DeleteCourse(int id)
        {
            var courseToDelete = _courses.FirstOrDefault(c => c.C_CourseId == id);
            if (courseToDelete != null)
                _courses.Remove(courseToDelete);
        }

        public IEnumerable<Courses> GetAllCourses()
        {
            return _courses;
        }

        public Courses GetCourseById(int id)
        {
            return _courses.FirstOrDefault(c => c.C_CourseId == id);
        }

        public bool SaveChanges()
        {
            return true;
        }

        public void UpdateCourse(Courses input)
        {
            var courseInTheList = _courses
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
