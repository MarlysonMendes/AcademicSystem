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
        private readonly List<Discipline> _disciplines = new List<Discipline>();

        private Course () { }
        
        public Guid CourseId { get; private set; }
        public string NameCourse { get; private set; }
 
        public List<Student> Students { get; private set; }
        public List<Teacher> Teachers { get; private set; }
       
        
        public Coordinator Coordinator { get;private set; }


        public IEnumerable<Discipline> Diciplinas { get { return _disciplines; } }


        public Departament Departament { get;private set; }
        public Guid DepartamentId { get; private set; }
    }
}
