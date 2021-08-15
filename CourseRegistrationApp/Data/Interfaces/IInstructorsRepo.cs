using CourseRegistrationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationApp.Data.Interfaces
{
    public interface IInstructorsRepo
    {
        IEnumerable<Instructors> GetAllInstructors();
    }
}
