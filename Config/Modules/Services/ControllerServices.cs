using API_Project.Config.Modules;
using API_Project.Services;

public class ControllerServicesModule : IServiceConfigModule
{
    public void ConfigureServices(IServiceCollection services, IConfiguration config)
    {
        services.AddScoped<UsersService>();
    }
}