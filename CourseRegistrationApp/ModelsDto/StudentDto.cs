using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.ModelsDto
{
    public class StudentDto
    {
        [DisplayName("Student Id")]
        public int S_Id { get; set; }
        [DisplayName("First Name")]
        public string S_FirstName { get; set; }
        [DisplayName("Last Name")]
        public string S_LastName { get; set; }
        [DisplayName("Email")]
        public string S_Email { get; set; }
        [DisplayName("Phone Number")]
        public string S_PhoneNumber { get; set; }

    }
}
