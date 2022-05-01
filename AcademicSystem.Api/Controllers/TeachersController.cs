using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AcademicSystem.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeachersController : Controller
    {
        private readonly IMapper _mapper;
        public TeachersController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTeachers()
        {
            return Ok();
        }

        [HttpGet("{teacherId}")]
        [ActionName(nameof(GetByIdTeacher))]
        public async Task<IActionResult> GetByIdTeacher(Guid teacherId)
        {
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> CreateTeacher()
        {

            return Ok();
        }
        [HttpPut("{teacherId}")]
        public async Task<IActionResult> UpdateTeacher(Guid teacherId)
        {

            return NoContent();
        }
        [HttpDelete("{teacherId}")]
        public async Task<IActionResult> DeleteTeacher(Guid teacherId)
        {
            return NoContent();
        }

    }
}
