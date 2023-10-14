using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Urans.Data;
using Urans.Dto_s;
using Urans.Entities;
using Urans.Repastory;
using Task = System.Threading.Tasks.Task;

namespace Urans.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepastory _userRepastory;
        public readonly AppDbContext _appDbContext;
        public UserController(IUserRepastory userRepastory,AppDbContext appDbContext)
        
        {
            _appDbContext = appDbContext;
            _userRepastory = userRepastory;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCourses(int id) => Ok(await _userRepastory.GetUserCourses(id));
        [HttpGet("id")]
        public async Task<IActionResult> GetUser (int id) => Ok(await _userRepastory.GetUserById(id));
        [HttpPost]
        public async Task<IActionResult> Registr(LoginDto loginDto)
        {
            var checkUser = await _appDbContext.User.FirstOrDefaultAsync(u => u.Email == loginDto.Email);
            if (checkUser == null)
            {
                return Ok(await _userRepastory.Registraktion(loginDto));
            }
            return Ok();
        }
      
    }
}
