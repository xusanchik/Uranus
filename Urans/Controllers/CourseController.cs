using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Urans.Entities;
using Urans.Interface;

namespace Urans.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepastory _courseRepastory;
        public CourseController(ICourseRepastory courseRepastory)
        {
            _courseRepastory = courseRepastory;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCourse() => Ok(await _courseRepastory.GetAllCourse());
        [HttpGet("id")]
        public async Task<IActionResult> GetIdCourse(int id) => Ok(await _courseRepastory.GetCourseById(id));
        [HttpPost]
        public async Task<IActionResult> CreateCourse(Course course) => Ok(await _courseRepastory.Add(course));


    }
}
