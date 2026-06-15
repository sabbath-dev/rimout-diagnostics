using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

await Host.CreateDefaultBuilder(args)
    .UseConsoleLifetime()
    .ConfigureServices(s=>s.AddHostedService<AgentHostedService>())
    .RunConsoleAsync();
