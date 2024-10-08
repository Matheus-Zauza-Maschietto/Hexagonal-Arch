using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.DTOs;

public record class CreateContactDTO(string Name, DateTime BornDate, ContactType Type, string Register, List<CreateMeanContactDTO> MeanContacts);
