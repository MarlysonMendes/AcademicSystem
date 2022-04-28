using AcademicSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Abstractions.Repositories
{
    public interface IDisciplineRepository
    {
        Task<List<Discipline>> GetAllDisciplinesOfCourseAsync(Guid courseId);
        Task<Discipline> GetByIdDisciplinesOfCourseAsync(Guid courseId,Guid disciplineId);
        Task<Discipline> CreateDisciplinesOfCourseAsync(Guid courseId, Discipline discipline);
        Task<Discipline> UpdateDisciplinesOfCourseAsync(Guid courseId,Discipline updateDiscipline);
        Task<Discipline> DeleteDisciplinesOfCourseAsync(Guid courseId, Guid disciplineId);
    }
}
