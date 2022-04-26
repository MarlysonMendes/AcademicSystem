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
    public class CourseRepository : ICourseRepository
    {
        private readonly DataContext _ctx;
        public CourseRepository(DataContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<List<Course>> GetAllCourseAsync()
        {
            return await _ctx.Courses
                .Include(c => c.Coordinator)
                .Include(c => c.Disciplines)
                .ToListAsync();
        }

        public async Task<Course> GetCourseByIdAsync(Guid courseId)
        {
            var course = await _ctx.Courses
                .Include(c => c.Coordinator)
                .Include(c => c.Disciplines)
                .FirstOrDefaultAsync(c => c.CourseId == courseId);
            return course;
        }
        public async Task<Course> CreateCourseAsync(Course course)
        {
            course.CourseId =  Guid.NewGuid();
            await _ctx.Courses.AddAsync(course);
            _ctx.SaveChanges();
            return course;
        }

        public async Task<Course> DeleteCourseAsync(Guid courseId)
        {
            var course = await _ctx.Courses.FirstOrDefaultAsync(c => c.CourseId == courseId);
            _ctx.Courses.Remove(course);
            await _ctx.SaveChangesAsync();

            return course;
        }

        public async Task<Course> UpdateCourseAsync(Course Updatecourse)
        {
            _ctx.Courses.Update(Updatecourse);
            await _ctx.SaveChangesAsync();
            return Updatecourse;
        }
    }
}
