using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todo_App.Models;

namespace Todo_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> GetTodos([FromBody]TodoRequest request)
        {
             return Ok(request);
        }

    }
}
