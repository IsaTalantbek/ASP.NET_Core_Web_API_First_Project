using API_Project.Config.Modules;

namespace API_Project.Config;

public class Configurator : IConfigurator
{
    private readonly IEnumerable<IServiceConfigModule> _configServiceModules;
    private readonly IEnumerable<IMiddlewareConfigModule> _configMiddlewareModules;

    public Configurator(
    IEnumerable<IServiceConfigModule> configServiceModules,
    IEnumerable<IMiddlewareConfigModule> configMiddlewareModules)
    {
        _configServiceModules = configServiceModules;
        _configMiddlewareModules = configMiddlewareModules;
    }

    public void ConfigureServices(IServiceCollection services, IConfiguration config)
    {
        foreach (var module in _configServiceModules)
        {
            module.ConfigureServices(services, config);
        }
    }
    public void Configure(WebApplication app)
    {
        foreach (var module in _configMiddlewareModules)
        {
            module.Configure(app);
        }
    }
}