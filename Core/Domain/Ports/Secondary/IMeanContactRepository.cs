using Domain.Entities;

namespace Domain.Secondary.Ports;

public interface IMeanContactRepository
{
    Task<MeanContact> CreateMeanContact(MeanContact meanContact);
    Task<MeanContact> DeleteMeanContact(int meanContactId);
    Task<MeanContact> UpdateMeanContact(MeanContact meanContact);
    Task<MeanContact> GetMeanContactById(int id);
}
