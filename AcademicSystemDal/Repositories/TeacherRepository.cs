using AcademicSystem.Domain.Abstractions.Repositories;
using AcademicSystem.Domain.Models.ProfileInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Dal.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        Task<Teacher> ITeacherRepository.CreateTeacherAsync(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        Task<Teacher> ITeacherRepository.DeleteTeacherAsync(Guid teacherId)
        {
            throw new NotImplementedException();
        }

        Task<List<Teacher>> ITeacherRepository.GetAllTeachersAsync()
        {
            throw new NotImplementedException();
        }

        Task<Teacher> ITeacherRepository.GetTeacherByIdAsync(Guid teacherId)
        {
            throw new NotImplementedException();
        }

        Task<Teacher> ITeacherRepository.UpdateTeacherAsync(Teacher updateTeacher)
        {
            throw new NotImplementedException();
        }
    }
}
