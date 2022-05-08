using Microsoft.AspNetCore.Mvc;
namespace AcademicSystem.Api.Controllers
{
    [Route(ApiRoutes.DepartamentsRoute.BaseRoute)]
    public class DepartamentController : Controller
    {
        public DepartamentController()
        {

        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepartament()
        {
            return Ok();
        }

        [HttpGet]
        [Route(ApiRoutes.DepartamentsRoute.idRoute)]
        public async Task<IActionResult> GetByIdDepartament(string departamentId)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDepartament()
        {
            return Ok();
        }
        [HttpDelete]
        [Route(ApiRoutes.DepartamentsRoute.idRoute)]
        public async Task<IActionResult> DeleteDepartament(string departamentId)
        {
            return Ok();
        }
        [HttpPatch]
        [Route(ApiRoutes.DepartamentsRoute.idRoute)]
        public async Task<IActionResult> UpdateDepartament(string departamentId)
        {
            return Ok();
        }
    }
}
