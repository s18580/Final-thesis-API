using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Final_thesis_api.Models.DTOs;
using Serilog;

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
        [Route("loginGoogle")]
        public async Task<IActionResult> LoginGoogle()
        {
            //ToDo
            Log.Information("Przykład logowania");
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
