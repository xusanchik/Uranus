using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Urans.Interface;

namespace Urans.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResaltController : ControllerBase
    {
        private readonly IResultRepastory _resultRepastory;
        public ResaltController(IResultRepastory resultRepastory)
        {
            _resultRepastory =  resultRepastory;
        }


        [HttpGet]
    public async Task<IActionResult> GetTaskById(int taskId) => Ok(await _resultRepastory.GetResultByIdAsync(taskId));

    }
}
