using AcademicSystem.Domain.Models.ProfileInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Models
{
    public class Discipline
    {
        public Guid DisciplineId { get; set; }
        public string DisciplineName { get; set;}
        public string DisciplineDescription { get; set;}
        public List<Student> Students { get; set; }
        public Guid CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
