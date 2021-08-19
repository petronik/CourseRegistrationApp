﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Models
{
    public class Instructors
    {
        [DisplayName("Instructor Id")]
        public int I_Id { get; set; }
        [DisplayName("First Name")]
        public string I_FirstName { get; set; }
        [DisplayName("Last Name")]
        public string I_LastName { get; set; }
        [DisplayName("Email")]
        public string I_Email { get; set; }
        [DisplayName("Course")]
        public int? C_CourseId { get; set; }
        public Courses Course { get; set; }
    }
}
