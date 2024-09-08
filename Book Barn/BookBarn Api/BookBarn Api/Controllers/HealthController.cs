using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookBarn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> CheckHealth()
        {
            return Ok("Good Health");
        }
    }
}
