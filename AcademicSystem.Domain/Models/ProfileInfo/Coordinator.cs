using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Models.ProfileInfo
{
    public class Coordinator 
    {
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public Guid CoordinatorId { get; set; }
        public Guid CourseId { get; set; }
        public string NameCourse { get; set; }
    }
}
