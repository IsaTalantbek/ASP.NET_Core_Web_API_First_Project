namespace API_Project.Config.Logging;

public class LoggingConfig
{
    private readonly ILoggingBuilder _logging;

    public LoggingConfig(ILoggingBuilder logging)
    {
        _logging = logging;
    }

    public void Configure()
    {
        _logging.AddConsole();
    }
}