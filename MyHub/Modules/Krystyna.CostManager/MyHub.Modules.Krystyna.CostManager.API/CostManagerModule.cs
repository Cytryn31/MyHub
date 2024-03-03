using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MyHub.Modules.Krystyna.CostManager.Core;
using MyHub.Modules.Krystyna.CostManager.Infrastructure;
using MyHub.Shared.Abstractions.Modules;

namespace MyHub.Modules.Krystyna.CostManager.API;


internal class CostManagerModule : IModule
{
    public const string BasePath = "krystyna.cost-manager-module";
    public string Name { get; } = "CostManager";
    public string Path => BasePath;

    public void Register(IServiceCollection services)
    {
        services
            .AddCore()
            .AddInfrastructure();
    }

    public void Use(IApplicationBuilder app)
    {
    }
}