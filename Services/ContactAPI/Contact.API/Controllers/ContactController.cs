using Contact.API.Infsracture;
using Contact.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class ContactController(IContactService contactService) : ControllerBase
    {
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ContactDto result =  contactService.GetContactById(id);
            return Ok(result);
        }
    }
}
