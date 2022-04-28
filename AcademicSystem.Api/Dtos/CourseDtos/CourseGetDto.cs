using AcademicSystem.Api.Dtos.CoordinatorDtos;
using AcademicSystem.Domain.Models;

namespace AcademicSystem.Api.Dtos.CourseDtos
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
