using Microsoft.EntityFrameworkCore;
using API_Project.Data;

namespace API_Project.Config.Modules;

public class DatabaseModule : IServiceConfigModule
{
    public void ConfigureServices(IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<ProjectDbContext>(
            options => options.UseSqlServer(
                config.GetConnectionString("Default")
            )
        );
    }
}