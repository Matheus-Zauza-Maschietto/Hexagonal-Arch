using Domain;
using Domain.Entities;
using Domain.Secondary.Ports;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data;

public class MeanContactRepository : IMeanContactRepository
{
    private readonly ApplicationDbContext _context;
    public MeanContactRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<MeanContact> CreateMeanContact(MeanContact meanContact)
    {
        MeanContact createMeanContact = _context.MeanContacts.Add(meanContact).Entity;
        await _context.SaveChangesAsync();
        return createMeanContact;
    }

    public async Task<MeanContact> DeleteMeanContact(int id)
    {
        MeanContact meanContact = await _context.MeanContacts.FirstAsync(p => p.Id == id);
        _context.MeanContacts.Remove(meanContact);
        return meanContact;
    }

    public async Task<MeanContact> UpdateMeanContact(MeanContact meanContact)
    {
        MeanContact updateMeanContact = _context.MeanContacts.Update(meanContact).Entity;
        await _context.SaveChangesAsync();
        return updateMeanContact;
    }

    public async Task<MeanContact?> GetMeanContactById(int id)
    {
        MeanContact? meanContact = await _context.MeanContacts.FirstOrDefaultAsync(p => p.Id == id);
        return meanContact;
    }

}
