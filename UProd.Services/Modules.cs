using Microsoft.Extensions.DependencyInjection;
using UProd.Services.Projects;

namespace UProd.Services;

public static class Modules
{
    public static IServiceCollection AddDependencyGroup(
        this IServiceCollection services)
    {
        services.AddScoped<ProjectService, ProjectService>();
        return services;
    }
}