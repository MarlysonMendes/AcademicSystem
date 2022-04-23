using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Models
{
    public class Course
    {
        public Guid CourseId { get; set; }
        public string NameCourse { get; set; }
        public List<Discipline> Disciplines { get; set; }
        public Teacher Coordinator { get; set; }
        public string Department { get; set; }
    }
}
