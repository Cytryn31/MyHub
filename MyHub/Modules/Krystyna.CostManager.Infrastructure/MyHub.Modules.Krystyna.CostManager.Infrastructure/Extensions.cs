using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using MyHub.Shared.Infrastructure.Postgres;

[assembly: InternalsVisibleTo("MyHub.Modules.Krystyna.CostManager.API")]
namespace MyHub.Modules.Krystyna.CostManager.Infrastructure;

internal static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddPostgres<CostManagerDbContext>();
        return services;
    }
}