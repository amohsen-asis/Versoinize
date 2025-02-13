    using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Versoinize.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("EmployeeController");
        }
    }
}
