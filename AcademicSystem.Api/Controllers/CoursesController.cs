using AcademicSystem.Domain.Abstractions.Repositories;
using AcademicSystem.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcademicSystem.Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CoursesController : Controller
    {
        private readonly ICourseRepository _courseRepository;
        public CoursesController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCourses()
        {
            var courses = await _courseRepository.GetAllCourseAsync();

            return Ok(courses);
        }
        [HttpGet("{courseId}")]
        public async Task<IActionResult> GetByIdCourse(Guid courseId)
        {
            var course = await _courseRepository.GetCourseByIdAsync(courseId);

            return Ok(course);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCourse([FromBody]Course createCourse)
        {
            createCourse.CourseId = Guid.NewGuid();
            var course = await _courseRepository.CreateCourseAsync(createCourse);

            return CreatedAtAction(nameof(GetByIdCourse),new {id = createCourse.CourseId},course);
        }

        [HttpPut("{courseId}")]
        public async Task<IActionResult> UpdateCourse(Guid courseId,[FromBody] Course updateCourse)
        {
            updateCourse.CourseId = courseId;
            var course = await _courseRepository.UpdateCourseAsync(updateCourse);
            return Ok(course);
        }

        [HttpDelete("{courseId}")]
        public async Task<IActionResult> DeleteCourse(Guid courseId)
        {
            
            var course = await _courseRepository.DeleteCourseAsync(courseId);
            return NoContent();
        }
    }
}
