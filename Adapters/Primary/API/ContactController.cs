using Domain;
using Microsoft.AspNetCore.Mvc;
namespace API
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        
        [HttpGet]
        public async Task<IActionResult> Teste(Contact contact)
        {
            return Problem();
        }
    }
}