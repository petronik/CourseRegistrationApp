using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Models
{
    public class Instructor
    {
        [Key]
        public int I_Id { get; set; }
        public string I_FirstName { get; set; }
        public string I_LastName { get; set; }
        public string I_Email { get; set; }
        [ForeignKey("Course")]
        public int? C_CourseId { get; set; }
        public Course Course { get; set; }
    }
}
