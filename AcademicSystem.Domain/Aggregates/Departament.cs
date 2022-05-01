using AcademicSystem.Domain.Aggregates.ProfileInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Aggregates
{
    public class Departament
    {
        private readonly List<Course> _courses = new List<Course>();
        private readonly List<Teacher> _teachers = new List<Teacher>();


        private Departament() { }

        public Guid DepartamentId { get; private set; }
        public string DepartamentName { get; private set; }



        public IEnumerable<Course> Courses { get { return _courses; } }
        public IEnumerable<Teacher> Teachers { get { return _teachers; } }

    }
}
