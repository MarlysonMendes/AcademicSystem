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
        public Guid DisciplineId { get; private set; }
        public string DisciplineName { get; private set;}
        public string DisciplineDescription { get; private set;}


        public List<Student> Students { get; private set; }

        public Course Course { get; private set; }
        public Guid CourseId { get; private set; }


        public Teacher Teacher { get; private set; }
    }
}
