namespace Rimout.Contracts;

public sealed record MetricBatch(IReadOnlyList<MetricSample> Metrics);
