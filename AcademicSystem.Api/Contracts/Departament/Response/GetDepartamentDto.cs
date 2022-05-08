using AcademicSystem.Domain.Aggregates;
using AcademicSystem.Domain.Aggregates.ProfileInfo;

namespace AcademicSystem.Api.Contracts.Departament.Response
{
    public record GetDepartamentDto
    {
        public Guid DepartamentId { get; set; }
        public string DepartamentName { get; set; }
        public  List<Course> Courses = new List<Course>();
        public  List<Teacher> Teachers = new List<Teacher>();
    }
}
