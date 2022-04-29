using AcademicSystem.Domain.Models.ProfileInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Abstractions.Repositories
{
    public interface ICoordinatorRepository
    {
        Task<Coordinator> GetCoordinatorOfCourseAsync(Guid courseId);
        Task<Coordinator> CreateCoordinatorOfCourseAsync(Guid courseId, Coordinator coordinator);
        Task<Coordinator> UpdateCoordinatorOfCourseAsync(Guid courseId, Coordinator updateCoordinator);
        Task<Coordinator> DeleteCoordinatorOfCourseAsync(Guid courseId, Guid coordinatorId);
    }
}
