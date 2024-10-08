using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.DTOs;

public record class UpdateContactDTO(string Name, DateTime BornDate, string Register);
