using CourseRegistrationApp.Models;
using CourseRegistrationApp.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Data
{
    public class Mapper
    {
        public Course Map(CourseDto input)
        {
            return new Course
            {
                C_CourseId = input.C_CourseId,
                C_CourseNumber = input.C_CourseNumber,
                C_CourseName = input.C_CourseName,
                C_CourseDescrip = input.C_CourseDescrip
            };
        }

        public CourseDto Map(Course input)
        {
            return new CourseDto
            {
                C_CourseId = input.C_CourseId,
                C_CourseNumber = input.C_CourseNumber,
                C_CourseName = input.C_CourseName,
                C_CourseDescrip = input.C_CourseDescrip
            };
        }

        public Student Map(StudentDto input)
        {
            return new Student
            {
                S_Id = input.S_Id,
                S_FirstName = input.S_FirstName,
                S_LastName = input.S_LastName,
                S_Email = input.S_Email,
                S_PhoneNumber = input.S_PhoneNumber,
                C_CourseId = input.C_CourseId
            };
        }

        public StudentDto Map(Student input)
        {
            return new StudentDto
            {
                S_Id = input.S_Id,
                S_FirstName = input.S_FirstName,
                S_LastName = input.S_LastName,
                S_Email = input.S_Email,
                S_PhoneNumber = input.S_PhoneNumber,
                C_CourseId = input.C_CourseId,
                Course = Map(input.Course )
            };
        }

        public Instructor Map(InstructorDto input)
        {
            return new Instructor
            {
                I_Id = input.I_Id,
                I_FirstName = input.I_FirstName,
                I_LastName = input.I_LastName,
                I_Email = input.I_Email,
                C_CourseId = input.C_CourseId
            };
        }
        public InstructorDto Map(Instructor input)
        {
            return new InstructorDto
            {
                I_Id = input.I_Id,
                I_FirstName = input.I_FirstName,
                I_LastName = input.I_LastName,
                I_Email = input.I_Email,
                C_CourseId = input.C_CourseId,
                Course = Map(input.Course)
            };
        }
    }
}
