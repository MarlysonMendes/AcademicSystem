using AcademicSystem.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcademicSystem.Api.Controllers
{
    [ApiController]
    [Route("/api[controller]")]
    public class CoursesController : Controller
    {

        CoursesController()
        {

        }

        [HttpGet]
        public async Task<IActionResult> GetAllCourses()
        {


            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetByIdCourse()
        {


            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCourse([FromBody]Course createCourse)
        {


            return Ok();
        }

    }
}
