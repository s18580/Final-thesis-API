using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Final_thesis_api.Models.DTOs;

namespace Final_thesis_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] UserLogin userLogin)
        {
            // run Authorize from SimpleJwtAuthenticationHandler

            return Ok();
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginGoogle()
        {
            //ToDo
            return Ok();
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> RegisterUser()
        {
            //ToDo
            return Ok();
        }
    }
}
