using AcademicSystem.Domain.Aggregates.ProfileInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Aggregates
{
    public class Course
    {
        public Guid CourseId { get; set; }
        public string NameCourse { get; set; }
        public List<Discipline> Disciplines { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public Coordinator Coordinator { get; set; }
        public string Department { get; set; }
    }
}
