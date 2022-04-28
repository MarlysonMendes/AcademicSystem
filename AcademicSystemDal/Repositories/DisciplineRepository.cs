using AcademicSystem.Domain.Abstractions.Repositories;
using AcademicSystem.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Dal.Repositories
{
    public class DisciplineRepository : IDisciplineRepository
    {
        private readonly DataContext _ctx;
        public DisciplineRepository(DataContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Discipline> CreateDisciplinesOfCourseAsync(Guid courseId, Discipline discipline)
        {
            var course = await _ctx.Courses
                .Include(c=> c.Disciplines)
                .FirstOrDefaultAsync(c=>c.CourseId == courseId);

            course.Disciplines.Add(discipline);
            await _ctx.SaveChangesAsync();
            return discipline;
            
        }

        public async Task<Discipline> DeleteDisciplinesOfCourseAsync(Guid courseId, Guid disciplineId)
        {
            var discipline = await _ctx.Disciplines
                .SingleOrDefaultAsync(d => d.CourseId == courseId && d.DisciplineId == disciplineId);

            if (discipline == null) return null;

            _ctx.Disciplines.Remove(discipline);
            await _ctx.SaveChangesAsync();
            return discipline;
        }

        public async Task<List<Discipline>> GetAllDisciplinesOfCourseAsync(Guid courseId)
        {
            var disciplines = await _ctx.Disciplines.Where(c=>c.CourseId == courseId).ToListAsync(); 
           return disciplines;
        }

        public async Task<Discipline> GetByIdDisciplinesOfCourseAsync(Guid courseId, Guid disciplineId)
        {
            var discipline = await _ctx.Disciplines
                .FirstOrDefaultAsync(d => d.CourseId == courseId && d.DisciplineId==disciplineId);

            return discipline;
        }

        public async Task<Discipline> UpdateDisciplinesOfCourseAsync( Discipline updateDiscipline)
        {
            _ctx.Disciplines.Update(updateDiscipline);
            await _ctx.SaveChangesAsync();
            return updateDiscipline;
        }
    }
}
