using AcademicSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Abstractions.Repositories
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetAllCourseAsync();
        Task<Course> GetCourseByIdAsync (Guid courseId);
        Task<Course> CreateCourseAsync(Course course);
        Task<Course> UpdateCourseAsync(Course Updatecourse);
        Task<Course> DeleteCourseAsync(Guid courseId);
    }
}
