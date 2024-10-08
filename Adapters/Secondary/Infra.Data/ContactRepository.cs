using Domain;
using Domain.Secondary.Ports;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data;

public class ContactRepository : IContactRepository
{
    private readonly ApplicationDbContext _context;
    public ContactRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Contact> CreateContact(Contact contact)
    {
        Contact createContact = _context.Contacts.Add(contact).Entity;
        await _context.SaveChangesAsync();
        return createContact;
    }

    public async Task<Contact> DeleteContact(int id)
    {
        Contact contact = await _context.Contacts.FirstAsync(p => p.Id == id);
        _context.Contacts.Remove(contact);
        return contact;
    }

    public async Task<Contact> UpdateContact(Contact contact)
    {
        Contact updateContact = _context.Contacts.Update(contact).Entity;
        await _context.SaveChangesAsync();
        return updateContact;
    }

    public async Task<Contact?> GetContactById(int id)
    {
        Contact? contact = await _context.Contacts.FirstOrDefaultAsync(p => p.Id == id);
        return contact;
    }

}
