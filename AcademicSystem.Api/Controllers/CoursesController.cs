using AcademicSystem.Api.Dtos.CourseDtos;
using AcademicSystem.Api.Dtos.CoordinatorDtos;
using AcademicSystem.Domain.Abstractions.Repositories;
using AcademicSystem.Domain.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AcademicSystem.Api.Dtos.DisciplineDtos;

namespace AcademicSystem.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : Controller
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IDisciplineRepository _disciplineRepository;
        private readonly IMapper _mapper;
        public CoursesController(ICourseRepository courseRepository, IMapper mapper, IDisciplineRepository disciplineRepository)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
            _disciplineRepository = disciplineRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCourses()
        {
            var courses = await _courseRepository.GetAllCourseAsync();
            var coursesGet = _mapper.Map<List<CourseGetDto>>(courses);
            return Ok(coursesGet);
        }
        // endpoint courses
        [HttpGet("{courseId}")]
        [ActionName(nameof(GetByIdCourse))]
        public async Task<IActionResult> GetByIdCourse(Guid courseId)
        {
            var course = await _courseRepository.GetCourseByIdAsync(courseId);
            var courseGet = _mapper.Map<CourseGetDto>(course);
            return Ok(courseGet);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCourse([FromBody] CoursePostPutDto createCourse)
        {

            var mapperCourse = _mapper.Map<Course>(createCourse);
            var course = await _courseRepository.CreateCourseAsync(mapperCourse);
            var courseGet = _mapper.Map<CourseGetDto>(course);

            return CreatedAtAction(nameof(GetByIdCourse), new { courseId = courseGet.CourseId }, courseGet);
        }
        [HttpPut("{courseId}")]
        public async Task<IActionResult> UpdateCourse(Guid courseId, [FromBody] CoursePostPutDto updateCourse)
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

        // endpoint courses/disciplines
        [HttpGet("{courseId}/discipline")]
        public async Task<IActionResult> GetAllDisciplinesOfCourse(Guid courseId)
        {
            var disciplines = await _disciplineRepository.GetAllDisciplinesOfCourseAsync(courseId);
            var discplinesGet = _mapper.Map<List<DisciplineGetDto>>(disciplines);
            return Ok(discplinesGet);
        }
        [HttpGet("{courseId}/discipline/{disciplineId}")]
        public async Task<IActionResult> GetByIdDisciplineOfCourse(Guid courseId, Guid disciplineId)
        {
            var disciplines = await _disciplineRepository.GetByIdDisciplinesOfCourseAsync(courseId,disciplineId);
            var discplineGet = _mapper.Map<DisciplineGetDto>(disciplines);
            return Ok(discplineGet);
        }
        [HttpPost("{courseId}/discipline")]
        public async Task<IActionResult> CreateDisciplineOfCourse(Guid courseId, [FromBody] DisciplinePostPutDto newDiscipline)
        {
            var createDiscipline = _mapper.Map<Discipline>(newDiscipline);
            var discipline = await _disciplineRepository.CreateDisciplinesOfCourseAsync(courseId, createDiscipline);
            var discplineGet = _mapper.Map<DisciplineGetDto>(discipline);
            return CreatedAtAction(nameof(GetByIdDisciplineOfCourse), 
                new { courseId = courseId, disciplineId = discplineGet.DisciplineId }, discplineGet);
        }

        [HttpPut("{courseId}/discipline/{disciplineId}")]
        public async Task<IActionResult> UpdateDisciplineOfCourse(Guid courseId, Guid disciplineId, [FromBody] DisciplinePostPutDto updateDiscipline)
        {
            var mapperDiscipline = _mapper.Map<Discipline>(updateDiscipline);
            mapperDiscipline.DisciplineId = disciplineId;
            var course = await _disciplineRepository.UpdateDisciplinesOfCourseAsync(courseId,mapperDiscipline);
            return NoContent();
        }
        [HttpDelete("{courseId}/discipline/{disciplineId}")]
        public async Task<IActionResult> DeleteDisciplineOfCourse(Guid courseId,Guid disciplineId)
        {
            var discpline = await _disciplineRepository.DeleteDisciplinesOfCourseAsync(courseId, disciplineId);
            return NoContent();
        }

    }
}
