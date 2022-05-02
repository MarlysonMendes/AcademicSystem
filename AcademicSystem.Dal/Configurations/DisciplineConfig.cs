using AcademicSystem.Domain.Aggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AcademicSystem.Dal.Configurations
{
    internal class DisciplineConfig : IEntityTypeConfiguration<Discipline>
    {
        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            //relacionamento 1 para muitos entre curso e disciplina
            //quando deletar um course vai deletar as disciplinas
            builder.HasOne(d => d.Course)
                .WithMany(c => c.Diciplinas)
                .OnDelete(DeleteBehavior.Cascade);

            //1 professor vai ter muitas disciplinas e 1 disciplina
            //vai ter um 1 professor

            builder.HasOne(d=>d.Teacher)
                .WithMany(t=>t.Diciplinas)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
