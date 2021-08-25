using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Models
{
    public class Student
    {
        [Key]
        public int S_Id { get; set; }
        public string S_FirstName { get; set; }
        public string S_LastName { get; set; }
        public string S_Email { get; set; }
        public string S_PhoneNumber { get; set; }
    }
}
