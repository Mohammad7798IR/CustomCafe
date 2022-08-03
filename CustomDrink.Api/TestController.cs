using Microsoft.AspNetCore.Mvc;
using CustomDrink.Common.Generators;


namespace CustomDrink.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("Index/{id?}")]
        public async Task<IActionResult> Index(string id)
        {
            var test = id.GenerateHash();

            return Ok(test);
        }
    }
}
