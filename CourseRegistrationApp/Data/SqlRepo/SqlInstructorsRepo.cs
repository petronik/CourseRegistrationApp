using CourseRegistrationApp.Data.Interfaces;
using CourseRegistrationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Data.SqlRepo
{
    public class SqlInstructorsRepo : IInstructorsRepo
    {
        private readonly AppDbContext _context;

        public SqlInstructorsRepo(AppDbContext context)
        {
            _context = context;
        }
        public void CreateInstructor(Instructor input)
        {
            if (input == null)
                throw new ArgumentException(nameof(input));

            _context.Instructors.Add(input);
        }

        public void DeleteInstructor(int id)
        {
            var instructorToDelete = GetInstructorById(id);
            if (instructorToDelete != null)
                _context.Instructors.Remove(instructorToDelete);
        }

        public IEnumerable<Instructor> GetAllInstructors()
        {
            return _context.Instructors.ToList();
        }

        public Instructor GetInstructorById(int id)
        {
            return _context.Instructors.FirstOrDefault(i => i.I_Id == id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UpdateInstructor(Instructor input)
        {
            var instructorsInTheList = _context.Instructors
                .FirstOrDefault(i => i.I_Id == input.I_Id);
            if (instructorsInTheList != null)
            {
                instructorsInTheList.I_FirstName = input.I_FirstName;
                instructorsInTheList.I_LastName = input.I_LastName;
                instructorsInTheList.I_Email = input.I_Email;
                instructorsInTheList.C_CourseId = input.C_CourseId;
            }
        }
    }
}
