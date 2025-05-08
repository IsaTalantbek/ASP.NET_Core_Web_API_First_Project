namespace API_Project.Config.Modules;

public class CoreModule : IConfigModule
{
    public void ConfigureServices(IServiceCollection services, IConfiguration config)
    {
        services.AddControllers();
    }
    public void Configure(WebApplication app)
    {
        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();
    }
}