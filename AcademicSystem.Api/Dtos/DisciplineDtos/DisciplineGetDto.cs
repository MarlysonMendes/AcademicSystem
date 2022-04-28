namespace AcademicSystem.Api.Dtos.DisciplineDtos
{
    public record DisciplineGetDto
    {
        public Guid DisciplineId { get; set; }
        public string DisciplineName { get; set; }
        public string DisciplineDescription { get; set; }
        public string CourseName { get; set; }
        public Guid CourseId { get; set; }

    }
}
