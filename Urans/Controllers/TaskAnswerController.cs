using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Urans.Entities;
using Urans.Interface;

namespace Urans.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskAnswerController : ControllerBase
    {
        private readonly ITaskAnswerRepastory _taskAnswerRepastory;
        public TaskAnswerController(ITaskAnswerRepastory taskAnswerRepastory)
        {
            _taskAnswerRepastory = taskAnswerRepastory;
        }
        [HttpGet]
        public async Task<IActionResult> AddTaskAnswer(TaskAnswer taskAnswer) => Ok(await _taskAnswerRepastory.AddTaskAnswer(taskAnswer));
    }
}
