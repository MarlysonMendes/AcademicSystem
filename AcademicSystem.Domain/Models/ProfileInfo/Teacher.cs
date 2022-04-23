using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Models
{
    public class Teacher
    {
        public Guid TeacherId { get; set; }
        public BasicInfo BasicInfo { get; set; }
        public UserProfile UserProfile { get; set; }
        public List<Discipline> Diciplinas { get; set; } 
    }
}
