using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Models
{
    public class Course
    {
        [Key]
        public int C_CourseId { get; set; }
        public int C_CourseNumber { get; set; }
        [Required]
        public string C_CourseName { get; set; }
        public string C_CourseDescrip { get; set; }
    }
}
