using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DTOs;
using Domain.Entities;
using Domain.Primary.Ports;
using Domain.Secondary.Ports;

namespace Application;

public class MeanContactService : IMeanContactService
{
    private readonly IMeanContactRepository _meanContactRepository;
    public MeanContactService(IMeanContactRepository meanContactRepository)
    {
        _meanContactRepository = meanContactRepository;
    }
    public async Task<MeanContact> CreateMeanContact(int contactId, CreateMeanContactDTO meanContact)
    {
        MeanContact createMeanContact = new MeanContact(meanContact);
        createMeanContact.contactId = contactId;
        MeanContact newMeanContact = await _meanContactRepository.CreateMeanContact(createMeanContact);
        return newMeanContact;
    }
    
    public async Task<MeanContact> DeleteMeanContact(int meanContactId)
    {
        MeanContact meanContact = await _meanContactRepository.GetMeanContact(meanContactId);
        MeanContact oldContact = await _meanContactRepository.DeleteMeanContact(meanContact.Id);
        return oldContact;
    }

    public async Task<MeanContact> UpdateMeanContact(UpdateMeanContactDTO meanContact)
    {
        MeanContact updateMeanContact = new MeanContact(meanContact);
        MeanContact newMeanContact = await _meanContactRepository.UpdateMeanContact(updateMeanContact);
        return newMeanContact;
    }

    public async Task<MeanContact> GetMeanContact(int id)
    {
        MeanContact meanContact = await _meanContactRepository.GetMeanContact(id);
        return meanContact;
    }
}
