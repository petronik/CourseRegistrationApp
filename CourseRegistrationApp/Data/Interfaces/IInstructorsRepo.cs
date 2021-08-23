using CourseRegistrationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Data.Interfaces
{
    public interface IInstructorsRepo
    {
        IEnumerable<Instructor> GetAllInstructors();
        void CreateInstructor(Instructor input);
        Instructor GetInstructorById(int id);
        void UpdateInstructor(Instructor input);
        void DeleteInstructor(int id);
        bool SaveChanges();
    }
}
