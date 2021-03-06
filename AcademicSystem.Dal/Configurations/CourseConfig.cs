using AcademicSystem.Domain.Aggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AcademicSystem.Dal.Configurations
{
    internal class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasOne(c=>c.Departament)
                .WithMany(d=>d.Courses)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
