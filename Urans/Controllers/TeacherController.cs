using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Urans.Entities;
using Urans.Interface;

namespace Urans.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepastory _teacherRepastory;
        public TeacherController(ITeacherRepastory teacherRepastory)
        {
            _teacherRepastory = teacherRepastory; 
            
        }
        [HttpGet]
        public async Task<IActionResult> GetALlTeacher() => Ok(await _teacherRepastory.GetAllTeacheAsync());
        [HttpGet("id")]
        public async Task<IActionResult> GetTeacher(int id) => Ok(await _teacherRepastory.GetTeacheByIdAsync(id));
        [HttpPost]
        public async Task<IActionResult> CreateTeacher(Teacher teacher) => Ok(await _teacherRepastory.AddTecherAsync(teacher));
        [HttpDelete]
        public async Task<IActionResult> DeleteTeacher(int id) => Ok(await _teacherRepastory.DeleteTeacherAsync(id));
    }
}
