using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Secondary.Ports;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Data;

public static class RepositoryApplicationExtensions
{
    public static IServiceCollection AddApplicationRepositories(this IServiceCollection services)
    {
        services.AddScoped<IContactRepository, ContactRepository>();
        services.AddScoped<IMeanContactRepository, MeanContactRepository>();
        return services;
    }
}
