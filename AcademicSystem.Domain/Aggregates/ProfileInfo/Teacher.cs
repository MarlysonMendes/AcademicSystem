using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Aggregates.ProfileInfo
{
    public class Teacher
    {
        private readonly List<Discipline> _disciplines = new List<Discipline>();

        private Teacher () { }

        public Guid TeacherId { get; set; }
        public BasicInfo BasicInfo { get; set; }

        public Departament Departament { get; private set; }
        public Guid DepartamentoId { get; private set; }


        public IEnumerable<Discipline> Diciplinas { get { return _disciplines; } }
        
        static Teacher CreateTeacher(BasicInfo newInfo,Guid guidTeacher)
        {
            return new Teacher
            {
                BasicInfo = newInfo,
                TeacherId = guidTeacher,
            };
        }

        public void UpdateTeacher(BasicInfo newInfo)
        {
            BasicInfo = newInfo;
        }
    }
}
