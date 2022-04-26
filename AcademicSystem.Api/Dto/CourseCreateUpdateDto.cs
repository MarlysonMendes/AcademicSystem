using System.ComponentModel.DataAnnotations;

namespace AcademicSystem.Api.Dto
{
    public record CourseCreateUpdateDto
    {
        [Required]
        public string NameCourse { get; set; }
        [Required]
        public string Department { get; set; }
    }
}
