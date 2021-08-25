using CourseRegistrationApp.Data.Interfaces;
using CourseRegistrationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Data.SqlRepo
{
    public class SqlStudentsRepo : IStudentRepo
    {
        private readonly AppDbContext _context;

        public SqlStudentsRepo(AppDbContext context)
        {
            _context = context;
        }
        public void CreateStudent(Student input)
        {
            if (input == null)
                throw new ArgumentException(nameof(input));

            _context.Students.Add(input);
        }

        public void DeleteStudent(int id)
        {
            var studentToDelete = GetStudentById(id);
            if (studentToDelete != null)
                _context.Students.Remove(studentToDelete);
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.S_Id == id);

        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UpdateStudent(Student input)
        {
            var studentInTheList = _context.Students
                .FirstOrDefault(s => s.S_Id == input.S_Id);

            if (studentInTheList != null)
            {
                studentInTheList.S_FirstName = input.S_FirstName;
                studentInTheList.S_LastName = input.S_LastName;
                studentInTheList.S_Email = input.S_Email;
                studentInTheList.S_PhoneNumber = input.S_PhoneNumber;

            }
        }
    }
}
