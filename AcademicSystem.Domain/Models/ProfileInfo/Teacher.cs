using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Models.ProfileInfo
{
    public class Teacher
    {
        public Guid TeacherId { get; set; }
        public BasicInfo BasicInfo { get; set; }
        public Guid BasicInfoId { get; set; }
        public UserProfile UserProfile { get; set; }
        public Guid UserProfileId { get; set; }
        public List<Discipline> Diciplinas { get; set; } 
    }
}
