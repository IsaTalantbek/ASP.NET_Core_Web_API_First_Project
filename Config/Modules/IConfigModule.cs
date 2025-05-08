namespace API_Project.Config.Modules;

public interface IConfigModule : IServiceConfigModule, IMiddlewareConfigModule;

public interface IServiceConfigModule
{
    void ConfigureServices(IServiceCollection services, IConfiguration config);
}

public interface IMiddlewareConfigModule
{
    void Configure(WebApplication app);
}