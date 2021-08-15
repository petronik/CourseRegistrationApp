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
            new Instructors{S_FirstName = "John", S_LastName = "Doe", S_Email = "johndoe@gmail.com", C_CourseId = 101},
            new Instructors{S_FirstName = "Bella", S_LastName = "Mandella", S_Email = "bellamandella@gmail.com", C_CourseId = 104},
            new Instructors{S_FirstName = "Paul", S_LastName = "Fisher", S_Email = "paulfisher@gmail.com", C_CourseId = 102},
            new Instructors{S_FirstName = "Simon", S_LastName = "Hill", S_Email = "simonhil@gmail.com", C_CourseId = 103}
        };
        public IEnumerable<Instructors> GetAllInstructors()
        {
            return _instructors;
        }
    }
}
