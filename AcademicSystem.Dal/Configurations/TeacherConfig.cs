using AcademicSystem.Domain.Aggregates.ProfileInfo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AcademicSystem.Dal.Configurations
{
    internal class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.OwnsOne(t => t.BasicInfo);

            builder.HasOne(t =>t.Departament)
                .WithMany(d=>d.Teachers)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
