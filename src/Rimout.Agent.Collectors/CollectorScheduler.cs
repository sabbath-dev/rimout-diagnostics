
namespace Rimout.Agent.Collectors;

public sealed class CollectorScheduler(IEnumerable<ICollector> collectors)
{
    public IEnumerable<ICollector> Collectors { get; } = collectors;
}
