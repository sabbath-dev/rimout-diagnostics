using Rimout.Contracts;

namespace Rimout.Agent.Collectors;

public interface ICollector
{
    string Name { get; }
    Task<MetricSample> CollectAsync(CancellationToken cancellationToken);
}
