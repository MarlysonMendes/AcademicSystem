using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Models
{
    public class Student
    {
        public string registration { get; set; }
        public BasicInfo BasicInfo { get; set; }
        public UserProfile UserProfile { get; set; }
        public List<Discipline> Diciplinas { get; set; }
        public List<ExamNote> ExamNotes { get; set; }
        public Course Course { get; set; }


    }
}
