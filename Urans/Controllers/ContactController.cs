using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Urans.Entities;
using Urans.Interface;

namespace Urans.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactRepastory _contactRepastory;
        public ContactController(IContactRepastory contactRepastory)
        {
            _contactRepastory = contactRepastory;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllContakt(Contact contact) => Ok(await _contactRepastory.GetAll());

        [HttpPost]
        public async Task<IActionResult> AddContact(Contact contact) => Ok(await _contactRepastory.AddContact(contact));
    }

}
