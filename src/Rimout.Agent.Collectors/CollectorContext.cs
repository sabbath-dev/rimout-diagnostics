namespace Rimout.Agent.Collectors;

public sealed class CollectorContext
{
    public DateTimeOffset StartedAt { get; } = DateTimeOffset.UtcNow;
}
