using AcademicSystem.Api.Dto;
using AcademicSystem.Domain.Abstractions.Repositories;
using AcademicSystem.Domain.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AcademicSystem.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : Controller
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;
        public CoursesController(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCourses()
        {
            var courses = await _courseRepository.GetAllCourseAsync();

            return Ok(courses);
        }
        
        [HttpGet("{courseId}")]
        [ActionName(nameof(GetByIdCourse))]

        public async Task<IActionResult> GetByIdCourse(Guid courseId)
        {
            var course = await _courseRepository.GetCourseByIdAsync(courseId);
            var courseGet = _mapper.Map<CourseGetDto>(course);
            return Ok(courseGet);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCourse([FromBody]CourseCreateUpdateDto createCourse)
        {

            var mapperCourse = _mapper.Map<Course>(createCourse);
            var course = await _courseRepository.CreateCourseAsync(mapperCourse);
            var courseGet = _mapper.Map<CourseGetDto>(course);

            return CreatedAtAction(nameof(GetByIdCourse),new {courseId = courseGet.CourseId},courseGet);
        }

        [HttpPut("{courseId}")]
        public async Task<IActionResult> UpdateCourse(Guid courseId,[FromBody] CourseCreateUpdateDto updateCourse)
        {
            var mapperCourse = _mapper.Map<Course>(updateCourse);
            mapperCourse.CourseId = courseId;
            var course = await _courseRepository.UpdateCourseAsync(mapperCourse);
            return NoContent();
        }

        [HttpDelete("{courseId}")]
        public async Task<IActionResult> DeleteCourse(Guid courseId)
        { 
            var course = await _courseRepository.DeleteCourseAsync(courseId);
            return NoContent();
        }
    }
}
