using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.DTOs;

public record class CreateMeanContactDTO(string Value, MeanContactType Type);
