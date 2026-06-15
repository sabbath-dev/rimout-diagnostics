namespace Rimout.Contracts;

public sealed record MetricSample(
    string Name,
    double Value,
    DateTimeOffset Timestamp);
