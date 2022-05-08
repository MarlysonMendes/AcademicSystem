using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Aggregates.ProfileInfo
{
    public class Student
    {
        private readonly List<Discipline> _disciplines = new List<Discipline>();


        private Student() { }
        public Guid StudentId { get; set; }
        public BasicInfo BasicInfo { get; set; }


        public Guid CourseId { get; private set; }
        public Course Course { get; private set; }

        public IEnumerable<Discipline> Diciplinas { get { return _disciplines; } }

    }
}
