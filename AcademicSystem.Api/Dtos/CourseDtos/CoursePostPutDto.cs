using System.ComponentModel.DataAnnotations;

namespace AcademicSystem.Api.Dtos.CourseDtos
{
    public record CoursePostPutDto
    {
        [Required]
        public string NameCourse { get; set; }
        [Required]
        public string Department { get; set; }
    }
}
