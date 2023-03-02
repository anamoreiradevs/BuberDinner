using BubberDinner.Application.Common.Interfaces.Authentication;
using BubberDinner.Application.Common.Interfaces.Services;
using BubberDinner.Infrastructur.Services;
using BubberDinner.Infrastructure.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BubberDinner.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection 
    services, Microsoft.Extensions.Configuration.ConfigurationManager configuration)
    {
        services.Configure<JwtTokenGenerator>(configuration.GetSection(JwtSettings.SectionName));
        
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        return services;
    }
}