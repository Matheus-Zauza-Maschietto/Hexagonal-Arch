using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DTOs;
using Domain.Enums;

namespace Domain.Entities;

public sealed class MeanContact
{
    public int Id { get; set; }
    public int contactId { get; set; }
    public Contact Contact { get; set; }
    public string Value { get; set; }
    public MeanContactType Type { get; set; }

    public MeanContact(CreateMeanContactDTO createMeanContactDTO)
    {
        Value = createMeanContactDTO.Value;
        Type = createMeanContactDTO.Type;
    }
    
    public MeanContact(UpdateMeanContactDTO updateMeanContactDTO)
    {
        Value = updateMeanContactDTO.Value;
    }
}
