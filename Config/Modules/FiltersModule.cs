using API_Project.Filters;

namespace API_Project.Config.Modules;

public class FiltersModule : IServiceConfigModule
{
    public void ConfigureServices(IServiceCollection services, IConfiguration config)
    {
        services.AddScoped<LoggingFilter>();
    }
}