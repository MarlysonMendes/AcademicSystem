using AcademicSystem.Domain.Models;
using AcademicSystem.Domain.Models.ProfileInfo;

namespace AcademicSystem.Api.Dto
{
    public record CourseGetDto
    {
        public Guid CourseId { get; set; }
        public string NameCourse { get; set; }
        public List<Discipline> Disciplines { get; set; }
        public CoordinatorGetDto Coordinator { get; set; }
        public string Department { get; set; }
    }
}
