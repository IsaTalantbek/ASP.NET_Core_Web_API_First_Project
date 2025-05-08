using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace API_Project.Filters;

public class LoggingFilter : IAsyncActionFilter
{
    private ILogger<LoggingFilter> _logger;

    public LoggingFilter(ILogger<LoggingFilter> logger)
    {
        _logger = logger;
    }

    public async Task OnActionExecutionAsync(
        ActionExecutingContext context, ActionExecutionDelegate next
    )
    {
        _logger.LogInformation("Название метода: " + context.ActionDescriptor.DisplayName);
        var resultContext = await next();

        var result = resultContext.Result;

        // Проверяем, является ли результат ObjectResult
        if (result is ObjectResult objectResult)
        {
            // Получаем значение из ObjectResult
            var value = objectResult.Value;

            // Логируем или используем значение
            _logger.LogInformation($"Результат метода: {value}");
        }
    }
}