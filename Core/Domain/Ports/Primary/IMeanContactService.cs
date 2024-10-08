using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DTOs;
using Domain.Entities;

namespace Domain.Primary.Ports;

public interface IMeanContactService
{
    Task<MeanContact> CreateMeanContact(int contactId, CreateMeanContactDTO meanContact);
    Task<MeanContact> DeleteMeanContact(int meanContactId);
    Task<MeanContact> UpdateMeanContact(UpdateMeanContactDTO meanContact);
    Task<MeanContact> GetMeanContact(int id);
}
