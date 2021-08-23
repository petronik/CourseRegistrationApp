using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.ModelsDto
{
    public class CourseDto
    {
        [DisplayName("Course Id")]
        public int C_CourseId { get; set; }
        [DisplayName("Number")]
        public int C_CourseNumber { get; set; }
        [DisplayName("Name")]
        [Required]
        public string C_CourseName { get; set; }
        [DisplayName("Description")]
        public string C_CourseDescrip { get; set; }
    }
}
