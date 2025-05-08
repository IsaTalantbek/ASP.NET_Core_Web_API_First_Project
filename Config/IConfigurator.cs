namespace API_Project.Config;

public interface IConfigurator
{
    public void ConfigureServices(IServiceCollection services, IConfiguration config);
    public void Configure(WebApplication app);
}