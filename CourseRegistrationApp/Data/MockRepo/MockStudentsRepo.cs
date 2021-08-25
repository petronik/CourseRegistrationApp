using CourseRegistrationApp.Data.Interfaces;
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
            new Student{S_Id = 3101, S_FirstName = "John", S_LastName = "Lenon", S_Email = "johnLenon@gmail.com", S_PhoneNumber = "123-456-67890"},
            new Student{S_Id = 3102, S_FirstName = "Ringo", S_LastName = "Starr", S_Email = "ringoStarr@gmail.com", S_PhoneNumber = "987-233-7755"},
            new Student{S_Id = 3103, S_FirstName = "Paul", S_LastName = "McCartney", S_Email = "paulmccartney@gmail.com", S_PhoneNumber = "321-654-4532"},
            new Student{S_Id = 3104, S_FirstName = "Geordge", S_LastName = "Harrison", S_Email = "georgeharrison@gmail.com", S_PhoneNumber = "233-342-7754"},
            new Student{S_Id = 3105, S_FirstName = "Steven", S_LastName = "Lenon", S_Email = "stevenLenon@gmail.com", S_PhoneNumber = "123-456-67890"},
            new Student{S_Id = 3106, S_FirstName = "Roger", S_LastName = "Starr", S_Email = "rogerStarr@gmail.com", S_PhoneNumber = "987-233-7755"},
            new Student{S_Id = 3107, S_FirstName = "Bob", S_LastName = "McCartney", S_Email = "bobmccartney@gmail.com", S_PhoneNumber = "321-654-4532"},
            new Student{S_Id = 3108, S_FirstName = "Briant", S_LastName = "Harrison", S_Email = "briantharrison@gmail.com", S_PhoneNumber = "233-342-7754"}
        
        };

        public void CreateStudent(Student input)
        {
            int code = _students.Max(c => c.S_Id) + 1;
            input.S_Id = code;
            _students.Add(input);
        }

        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _students;
        }

        public Student GetStudentById(int id)
        {
            return _students.FirstOrDefault(s => s.S_Id == id);
        }

        public bool SaveChanges()
        {
            return true;
        }

        public void UpdateStudent(Student input)
        {
            var studentInTheList = _students
                .FirstOrDefault(s => s.S_Id == input.S_Id);

            if (studentInTheList != null)
            {
                studentInTheList.S_FirstName = input.S_FirstName;
                studentInTheList.S_LastName  = input.S_LastName;
                studentInTheList.S_Email = input.S_Email;
                studentInTheList.S_PhoneNumber = input.S_PhoneNumber;
            }
        }
    }
}
