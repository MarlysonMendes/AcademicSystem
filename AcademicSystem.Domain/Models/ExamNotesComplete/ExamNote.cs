using AcademicSystem.Domain.Models.ExamNotesComplete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Models
{
    public class ExamNote
    {
        public Guid ExamNoteId { get; set; }
        public FirstStage FirstStage { get; set; }
        public SecondStage SecondStage { get; set; }
        public float FinalResult { get; set; }
        public float FinalTest { get; set; }
        public Student Student { get; set; }
        public Discipline Discipline { get; set; }

    }
}
