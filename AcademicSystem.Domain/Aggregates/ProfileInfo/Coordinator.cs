using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Aggregates.ProfileInfo
{
    public class Coordinator 
    {

        public Guid CoordinatorId { get; set; }
        public BasicInfo BasicInfo { get; set; }
        public string IdentityId { get; private set; }


        public Guid CourseId { get; set; }
        public string CourseName { get; private set; }
    }
}
