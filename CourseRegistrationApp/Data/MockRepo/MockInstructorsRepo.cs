using CourseRegistrationApp.Data.Interfaces;
using CourseRegistrationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Data.MockRepo
{
    public class MockInstructorsRepo : IInstructorsRepo
    {
        private readonly static List<Instructors> _instructors = new List<Instructors>
        {
            new Instructors{I_Id = 2500,I_FirstName = "John", I_LastName = "Doe", I_Email = "johndoe@gmail.com", C_CourseId = 101},
            new Instructors{I_Id = 2500,I_FirstName = "Bella", I_LastName = "Mandella", I_Email = "bellamandella@gmail.com", C_CourseId = 104},
            new Instructors{I_Id = 2500,I_FirstName = "Paul", I_LastName = "Fisher", I_Email = "paulfisher@gmail.com", C_CourseId = 102},
            new Instructors{I_Id = 2500,I_FirstName = "Simon", I_LastName = "Hill", I_Email = "simonhil@gmail.com", C_CourseId = 103}
        };
        public IEnumerable<Instructors> GetAllInstructors()
        {
            return _instructors;
        }
    }
}
