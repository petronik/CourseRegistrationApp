using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Models
{
    public class Instructors
    {
        [DisplayName("First Name")]
        public string S_FirstName { get; set; }
        [DisplayName("Last Name")]
        public string S_LastName { get; set; }
        [DisplayName("Email")]
        public string S_Email { get; set; }
        [DisplayName("Course ID")]
        public int? C_CourseId { get; set; }
        public Courses Course { get; set; }
    }
}
