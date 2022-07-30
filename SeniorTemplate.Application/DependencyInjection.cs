using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NeerCore.Application.Extensions;
using NeerCore.DependencyInjection.Extensions;
using NeerCore.Mapping.Extensions;

namespace SeniorTemplate.Application;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
    }
}