using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.ViewModel
{
    public class SaveStudentsInCourseVM
    {
        public List<StudentVM> Student { get; set; }
        public int CourseId { get; set; }
    }
}
