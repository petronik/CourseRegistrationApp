using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Models
{
    public class Instructors
    {
        public string S_FirstName { get; set; }
        public string S_LastName { get; set; }
        public string S_Email { get; set; }
        public int? C_CourseId { get; set; }
        public Courses Course { get; set; }
    }
}
