﻿using CourseRegistrationApp.Data.Interfaces;
using CourseRegistrationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Data.MockRepo
{
    public class MockStudentsRepo : IStudentRepo
    {
        private readonly static List<Student> _students = new List<Student> { 
            new Student{S_FirstName = "John", S_LastName = "Lenon", S_Email = "johnLenon@gmail.com", S_PhoneNumber = "123-456-67890", C_CourseId = 104},
            new Student{S_FirstName = "Ringo", S_LastName = "Starr", S_Email = "ringoStarr@gmail.com", S_PhoneNumber = "987-233-7755", C_CourseId = 102},
            new Student{S_FirstName = "Paul", S_LastName = "McCartney", S_Email = "paulmccartney@gmail.com", S_PhoneNumber = "321-654-4532", C_CourseId = 104},
            new Student{S_FirstName = "Geordge", S_LastName = "Harrison", S_Email = "georgeharrison@gmail.com", S_PhoneNumber = "233-342-7754", C_CourseId = 102},
            new Student{S_FirstName = "Steven", S_LastName = "Lenon", S_Email = "johnLenon@gmail.com", S_PhoneNumber = "123-456-67890", C_CourseId = 103},
            new Student{S_FirstName = "Roger", S_LastName = "Starr", S_Email = "ringoStarr@gmail.com", S_PhoneNumber = "987-233-7755", C_CourseId = 103},
            new Student{S_FirstName = "Bob", S_LastName = "McCartney", S_Email = "paulmccartney@gmail.com", S_PhoneNumber = "321-654-4532", C_CourseId = 103},
            new Student{S_FirstName = "Briant", S_LastName = "Harrison", S_Email = "georgeharrison@gmail.com", S_PhoneNumber = "233-342-7754", C_CourseId = 103}
        
        };
        public IEnumerable<Student> GetAllStudents()
        {
            return _students;
        }
    }
}
