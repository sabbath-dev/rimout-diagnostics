namespace Rimout.Contracts;

public sealed record Heartbeat(
    string AgentId,
    DateTimeOffset Timestamp);
