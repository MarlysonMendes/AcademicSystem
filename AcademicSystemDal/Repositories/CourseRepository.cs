using AcademicSystem.Domain.Abstractions.Repositories;
using AcademicSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Dal.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        public Task<List<Course>> GetAllCourseAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Course> GetCourseByIdAsync(Guid courseId)
        {
            throw new NotImplementedException();
        }
        public Task<Course> CreateCourseAsync(Course course)
        {
            throw new NotImplementedException();
        }

        public Task<Course> DeleteCourseAsync(Guid courseId)
        {
            throw new NotImplementedException();
        }

        public Task<Course> UpdateCourseAsync(Course Updatecourse)
        {
            throw new NotImplementedException();
        }
    }
}
