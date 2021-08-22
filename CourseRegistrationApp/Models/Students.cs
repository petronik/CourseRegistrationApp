using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Models
{
    public class Students
    {
        [DisplayName("Student Id")]
        [Key]
        public int S_Id { get; set; }
        [DisplayName("First Name")]
        public string S_FirstName { get; set; }
        [DisplayName("Last Name")]
        public string S_LastName { get; set; }
        [DisplayName("Email")]
        public string S_Email { get; set; }
        [DisplayName("Phone Number")]
        public string S_PhoneNumber { get; set; }
        [DisplayName("Course")]
        [ForeignKey("Course")]
        public int? C_CourseId { get; set; }
        public Courses Course { get; set; }


    }
}
