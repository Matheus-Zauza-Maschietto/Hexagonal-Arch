using Domain;
using Domain.DTOs;
using Domain.Primary.Ports;
using Microsoft.AspNetCore.Mvc;
namespace API;

[ApiController]
[Route("api/[controller]")]
public class ContactController : ControllerBase
{    
    private readonly IContactService _contactService;
    public ContactController(IContactService contactService)
    {
        _contactService = contactService;   
    }

    [HttpPost]
    public async Task<IActionResult> CreateContact(CreateContactDTO contact)
    {
        Contact createdContact = await _contactService.CreateContact(contact);
        return Ok(createdContact);
    }

    [HttpGet("{contactId:int}")]
    public async Task<IActionResult> GetContact([FromRoute]int contactId)
    {
        Contact contact = await _contactService.GetContactById(contactId);
        return Ok(contact);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateContact(UpdateContactDTO contact)
    {
        Contact updatedContact = await _contactService.UpdateContact(contact);
        return Ok(updatedContact);
    }

    [HttpDelete("{contactId:int}")]
    public async Task<IActionResult> DeleteContact([FromRoute]int contactId)
    {
        Contact deletedContact = await _contactService.DeleteContact(contactId);
        return Ok(deletedContact);
    }
}
