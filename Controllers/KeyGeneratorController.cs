using Microsoft.AspNetCore.Mvc;
using KeyAPI.Model;

namespace KeyAPI.Controllers
{
    [ApiController]
    [Route("api/V1/[Controller]")]
    public class KeyGeneratorController : Controller
    {
        [HttpGet]
        [Route("GetUniquekey")]
        public IActionResult GenerateUniqueKey()
        {
            var uniqueKey=Guid.NewGuid().ToString();
            var result = new UniqueKey
            {
                Key = uniqueKey,
                CreatedAt = DateTime.UtcNow
            };

            return Ok(result);
        }

         
    }
}
