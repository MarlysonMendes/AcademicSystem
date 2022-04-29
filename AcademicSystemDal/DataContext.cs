using AcademicSystem.Domain.Models;
using AcademicSystem.Domain.Models.ProfileInfo;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Dal
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions options) : base (options)
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Coordinator> Coodinatores { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

              builder.Entity<Discipline>()
              .HasMany(d => d.Students)
              .WithMany(s => s.Diciplinas)
              .UsingEntity<Dictionary<string, object>>(
              "DisciplineStudents",
              j => j.HasOne<Student>().WithMany().OnDelete(DeleteBehavior.Restrict),
              j => j.HasOne<Discipline>().WithMany().OnDelete(DeleteBehavior.Restrict));
            
            base.OnModelCreating(builder); 
        }
    }
}
