// Практическое применение полученных знаний на проекте 

using API_Project.Config;
using API_Project.Config.Logging;

namespace API_Project.Startup;

public class Program
{
    private static readonly IConfigurator configurator = new ConfigureModules().CreateConfigurator();

    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        ConfigureBuilder(builder);

        var app = builder.Build();

        ConfigureApp(app);

        app.Run();
    }

    private static void ConfigureBuilder(WebApplicationBuilder builder)
    {
        new LoggingConfig(builder.Logging).Configure();

        configurator.ConfigureServices(builder.Services, builder.Configuration);
    }

    private static void ConfigureApp(WebApplication app)
    {
        configurator.Configure(app);
    }
}