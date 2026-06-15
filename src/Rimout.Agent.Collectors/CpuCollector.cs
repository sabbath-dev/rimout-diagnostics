using Rimout.Contracts;

namespace Rimout.Agent.Collectors;

public sealed class CpuCollector : ICollector
{
    public string Name => "cpu";

    public Task<MetricSample> CollectAsync(CancellationToken cancellationToken) =>
        Task.FromResult(new MetricSample(Name, Random.Shared.NextDouble() * 100, DateTimeOffset.UtcNow));
}
