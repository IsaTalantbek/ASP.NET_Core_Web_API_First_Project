using API_Project.Config;
using API_Project.Config.Modules;

namespace API_Project.Startup;

public class ConfigureModules : IConfiguratorFactory
{
    private static IConfigModule coreModule = new CoreModule();
    private static IConfigModule swaggerModule = new SwaggerModule();
    private static IServiceConfigModule databaseModule = new DatabaseModule();
    private static IServiceConfigModule controllerServicesModule = new ControllerServicesModule();
    private static IServiceConfigModule filtersModule = new FiltersModule();

    private static IServiceConfigModule[] serviceModules =
    [
        coreModule,
        databaseModule,
        swaggerModule,
        controllerServicesModule,
        filtersModule
    ];

    private static IMiddlewareConfigModule[] middlewareModules =
    [
        coreModule,
        swaggerModule
    ];

    public IConfigurator CreateConfigurator()
    {
        return new Configurator(serviceModules, middlewareModules);
    }
}