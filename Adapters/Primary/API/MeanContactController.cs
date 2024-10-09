using Domain;
using Domain.DTOs;
using Domain.Entities;
using Domain.Primary.Ports;
using Microsoft.AspNetCore.Mvc;
namespace API;

[ApiController]
[Route("api/[controller]")]
public class MeanContactController : ControllerBase
{    
    private readonly IMeanContactService _meanContactService;
    public MeanContactController(IMeanContactService meanContactService)
    {
        _meanContactService = meanContactService;   
    }

    [HttpPost("contact/{contactId:int}")]
    public async Task<IActionResult> CreateContact([FromRoute]int contactId, CreateMeanContactDTO meanContact)
    {
        MeanContact createdMeanContact = await _meanContactService.CreateMeanContact(contactId, meanContact);
        return Ok(createdMeanContact);
    }

    [HttpGet("{meanContactId:int}")]
    public async Task<IActionResult> GetContact([FromRoute]int meanContactId)
    {
        MeanContact meanContact = await _meanContactService.GetMeanContact(meanContactId);
        return Ok(meanContact);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateContact(UpdateMeanContactDTO meanContact)
    {
        MeanContact updatedMeanContact = await _meanContactService.UpdateMeanContact(meanContact);
        return Ok(updatedMeanContact);
    }

    [HttpDelete("{meanContactId:int}")]
    public async Task<IActionResult> DeleteContact([FromRoute]int meanContactId)
    {
        MeanContact deletedMeanContact = await _meanContactService.DeleteMeanContact(meanContactId);
        return Ok(deletedMeanContact);
    }
}
