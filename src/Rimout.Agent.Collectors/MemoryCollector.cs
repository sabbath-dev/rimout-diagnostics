using Rimout.Contracts;

namespace Rimout.Agent.Collectors;

public sealed class MemoryCollector : ICollector
{
    public string Name => "memory";

    public Task<MetricSample> CollectAsync(CancellationToken cancellationToken) =>
        Task.FromResult(new MetricSample(Name, GC.GetTotalMemory(false), DateTimeOffset.UtcNow));
}
