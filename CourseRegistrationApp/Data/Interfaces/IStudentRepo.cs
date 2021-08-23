using CourseRegistrationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Data.Interfaces
{
    public interface IStudentRepo
    {
        IEnumerable<Student> GetAllStudents();
        void CreateStudent(Student input);
        Student GetStudentById(int id);
        void UpdateStudent(Student input);
        void DeleteStudent(int id);
        bool SaveChanges();
    }
}
