using CourseRegistrationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Data.Interfaces
{
    public interface IStudentRepo
    {
        IEnumerable<Students> GetAllStudents();
        void CreateStudent(Students input);
        Students GetStudentById(int id);
        void UpdateStudent(Students input);
        void DeleteStudent(int id);
        bool SaveChanges();
    }
}
