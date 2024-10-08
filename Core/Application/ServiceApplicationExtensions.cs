using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Primary.Ports;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ServiceApplicationExtensions
{
    public static void AddApplicationService(this IServiceCollection services)
    {
        services.AddScoped<IContactService, ContactService>();
        services.AddScoped<IMeanContactService, MeanContactService>();

    }
}
