using Microsoft.AspNetCore.Mvc;

namespace api
{
    [ApiController]
    [Route("api/example")]
    public class ExampleController : ControllerBase
    {

        [HttpPost]
        public IActionResult Post(ExampleCommand model)
        {
            return Ok(true);
        }
    }
}
