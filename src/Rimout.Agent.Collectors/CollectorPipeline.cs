using Rimout.Contracts;

namespace Rimout.Agent.Collectors;

public sealed class CollectorPipeline
{
    private readonly IEnumerable<ICollector> _collectors;

    public CollectorPipeline(IEnumerable<ICollector> collectors)
    {
        _collectors = collectors;
    }

    public async Task<MetricBatch> CollectAsync(CancellationToken ct)
    {
        var metrics = new List<MetricSample>();

        foreach (var collector in _collectors)
        {
            metrics.Add(await collector.CollectAsync(ct));
        }

        return new MetricBatch(metrics);
    }
}
