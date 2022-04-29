using AcademicSystem.Domain.Abstractions.Repositories;
using AcademicSystem.Domain.Models.ProfileInfo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Dal.Repositories
{
    public class CoordinatorRepository : ICoordinatorRepository
    {
        private readonly DataContext _ctx;
        public CoordinatorRepository(DataContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<Coordinator> CreateCoordinatorOfCourseAsync(Guid courseId, Coordinator coordinator)
        {
            var course = await _ctx.Courses
                .Include(c => c.Coordinator)
                .FirstOrDefaultAsync(c=> c.CourseId == courseId);

            course.Coordinator = coordinator;
            await _ctx.SaveChangesAsync();
            return coordinator;
        }

        public async Task<Coordinator> DeleteCoordinatorOfCourseAsync(Guid courseId, Guid coordinatorId)
        {
            var coordinator = await _ctx.Coodinatores
                .FirstOrDefaultAsync (c => c.CourseId == courseId && c.CoordinatorId == coordinatorId);
            if (coordinator == null) return null;

            await _ctx.SaveChangesAsync();
            return coordinator;
        }

        public async Task<Coordinator> GetCoordinatorOfCourseAsync(Guid courseId)
        {
            var coordinator = await _ctx.Coodinatores.FirstOrDefaultAsync(c => c.CourseId == courseId);
            return coordinator;
        }

        public async Task<Coordinator> UpdateCoordinatorOfCourseAsync(Guid courseId, Coordinator updateCoordinator)
        {
            var course = await _ctx.Courses
                .FirstOrDefaultAsync(c => c.CourseId == courseId);
            updateCoordinator.NameCourse = course.NameCourse;
            updateCoordinator.CourseId = courseId;
            
            _ctx.Coodinatores.Update(updateCoordinator);
            await _ctx.SaveChangesAsync();
            return updateCoordinator;
        }
    }
}
