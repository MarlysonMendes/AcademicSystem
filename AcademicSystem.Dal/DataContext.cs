using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using AcademicSystem.Domain.Aggregates.ProfileInfo;
using AcademicSystem.Dal.Configurations;
using AcademicSystem.Domain.Aggregates;

namespace AcademicSystem.Dal
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Coordinator> Coordinator { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Departament> Departaments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new StudentConfig());
            builder.ApplyConfiguration(new CoordinatorConfig());
            builder.ApplyConfiguration(new TeacherConfig());
            builder.ApplyConfiguration(new DisciplineConfig());
            builder.ApplyConfiguration(new CourseConfig());
            builder.ApplyConfiguration(new DepartamentConfig());
            base.OnModelCreating(builder);
        }
    }
}