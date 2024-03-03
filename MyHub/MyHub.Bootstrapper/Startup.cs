using System.Reflection;
using MyHub.Shared.Abstractions.Modules;
using MyHub.Shared.Infrastructure;

namespace MyHub.Bootstrapper;

public class Startup
{
    private readonly IList<Assembly> _assemblies;
    private readonly IList<IModule> _modules;

    public Startup(IConfiguration configuration)
    {
        _assemblies = ModuleLoader.LoadAssemblies(configuration);
        _modules = ModuleLoader.LoadModules(_assemblies);
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddInfrastructure(_assemblies, _modules);
        foreach (var module in _modules)
        {
            module.Register(services);
        }
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
    {
        logger.LogInformation($"Modules: {string.Join(", ", _modules.Select(x => x.Name))}");
        app.UseInfrastructure();
        foreach (var module in _modules)
        {
            module.Use(app);
        }
            
        _assemblies.Clear();
        _modules.Clear();
    }
}