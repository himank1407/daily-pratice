using Microsoft.AspNetCore.Mvc;

namespace CounterAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CounterController : ControllerBase
    {
        private static int count = 0;

        [HttpGet("count")]
        public IActionResult GetCount()
        {
            return Ok(count);
        }

        [HttpPost("increment")]
        public IActionResult Increment()
        {
            count++;
            return Ok(count);
        }

        [HttpPost("decrement")]
        public IActionResult Decrement()
        {
            count--;
            return Ok(count);
        }
    }
}