using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Models.ProfileInfo
{
    public class Coordinator : Teacher
    {
        public Course CoordinatorCourse { get; set; }
    }
}
