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
        private readonly static List<Instructor> _instructors = new List<Instructor>
        {
            new Instructor{I_Id = 2501,I_FirstName = "John", I_LastName = "Doe", I_Email = "johndoe@gmail.com", C_CourseId = 101},
            new Instructor{I_Id = 2502,I_FirstName = "Bella", I_LastName = "Mandella", I_Email = "bellamandella@gmail.com", C_CourseId = 104},
            new Instructor{I_Id = 2503,I_FirstName = "Paul", I_LastName = "Fisher", I_Email = "paulfisher@gmail.com", C_CourseId = 102},
            new Instructor{I_Id = 2504,I_FirstName = "Simon", I_LastName = "Hill", I_Email = "simonhil@gmail.com", C_CourseId = 103}
        };

        public void CreateInstructor(Instructor input)
        {
            int code = _instructors.Max(c => c.I_Id) + 1;
            input.I_Id = code;
            _instructors.Add(input);
        }

        public IEnumerable<Instructor> GetAllInstructors()
        {
            return _instructors;
        }
    }
}
