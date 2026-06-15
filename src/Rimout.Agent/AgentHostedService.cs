using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

public sealed class AgentHostedService(ILogger<AgentHostedService> logger):BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        logger.LogInformation("Rimout Agent started.");
        while(!stoppingToken.IsCancellationRequested)
        {
            logger.LogInformation("Heartbeat {Time}", DateTimeOffset.UtcNow);
            await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
        }
    }
}
