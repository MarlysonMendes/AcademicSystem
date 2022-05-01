using AcademicSystem.Domain.Aggregates;
using AcademicSystem.Domain.Aggregates.ProfileInfo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AcademicSystem.Dal.Configurations
{
    internal class CoordinatorConfig : IEntityTypeConfiguration<Coordinator>
    {
        public void Configure(EntityTypeBuilder<Coordinator> builder)
        {
            builder.OwnsOne(c => c.BasicInfo);


            //relacionamento 1 para 1 onde a chave estranfeira esta em course
            builder.HasOne(c => c.Course)
                .WithOne(course=> course.Coordinator)
                .HasForeignKey<Course>(course =>  course.CoordinatorId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
