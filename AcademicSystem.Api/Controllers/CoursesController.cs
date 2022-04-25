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

    }
}
