using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.DTOs;
using Domain.Primary.Ports;
using Domain.Secondary.Ports;

namespace Application;

public class ContactService : IContactService
{
    private readonly IContactRepository _contactRepository;
    public ContactService(IContactRepository contactRepository)
    {
        _contactRepository = contactRepository;
    }

    public async Task<Contact> CreateContact(CreateContactDTO contact)
    {
        Contact createContact = new Contact(contact);
        Contact newContact = await _contactRepository.CreateContact(createContact);
        return newContact;
    }
    public async Task<Contact> DeleteContact(int id)
    {
        Contact contact = await _contactRepository.GetContactById(id);
        Contact oldContact = await _contactRepository.DeleteContact(contact.Id);
        return oldContact;
    }
    public async Task<Contact> UpdateContact(UpdateContactDTO contact)
    {
        Contact updateContact = new Contact(contact);
        Contact newContact = await _contactRepository.UpdateContact(updateContact);
        return newContact;
    }    
    public async Task<Contact> GetContactById(int id)
    {
        Contact contact = await _contactRepository.GetContactById(id);
        return contact;
    }
}
