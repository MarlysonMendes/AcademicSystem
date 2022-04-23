using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Models
{
    public class Class
    {
        public Guid ClassId { get; set; }
        public Discipline Discipline { get; set; }
        public List<Student> StudentsPresent { get; set; }
    }
}
