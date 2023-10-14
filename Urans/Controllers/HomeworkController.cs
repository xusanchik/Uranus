using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Urans.Interface;

namespace Urans.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeworkController : ControllerBase
    {
        private readonly IHomworkRepastory _homworkRepastory;
        public HomeworkController(IHomworkRepastory homworkRepastory)
        {
            _homworkRepastory = homworkRepastory;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllHomework() => Ok(await _homworkRepastory.GetAllHomeworkAsync());
    }
}
