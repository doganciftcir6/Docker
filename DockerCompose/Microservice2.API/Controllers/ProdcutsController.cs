using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservice2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdcutsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { id = 1, name = "Pencil 2 (Microservice 2)" });
        }
    }
}
