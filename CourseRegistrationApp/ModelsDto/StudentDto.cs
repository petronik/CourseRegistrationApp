using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.ModelsDto
{
    public class StudentDto
    {
        [DisplayName("Student Id")]
        public int S_Id { get; set; }
        [DisplayName("First Name")]
        [Required]
        public string S_FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required]
        public string S_LastName { get; set; }
        [DisplayName("Email")]
        [Required]
        public string S_Email { get; set; }
        [DisplayName("Phone Number")]
        [Required]
        [ StringLength  ( 10, ErrorMessage = "Maximum 10 digits")]
        public string S_PhoneNumber { get; set; }

    }
}
