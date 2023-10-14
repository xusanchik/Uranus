using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Urans.Interface;

namespace Urans.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepastory _taskRepastory;
        public TaskController(ITaskRepastory taskRepastory)
        {
            _taskRepastory = taskRepastory;
        }
        [HttpGet]
        public async Task<IActionResult> GetTaskById(int taskId) => Ok(await _taskRepastory.GetTaskByIdAsync(taskId));



    }
}
