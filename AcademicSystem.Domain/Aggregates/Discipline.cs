using AcademicSystem.Domain.Aggregates.ProfileInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Aggregates
{
    public class Discipline
    {
        public Guid DisciplineId { get; set; }
        public string DisciplineName { get; set;}
        public string DisciplineDescription { get; set;}


        public List<Student> Students { get; set; }
        public Guid CourseId { get; set; }
        public string CourseName { get; set; }
        public Teacher Teacher { get; set; }
    }
}
