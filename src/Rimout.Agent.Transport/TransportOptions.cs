namespace Rimout.Agent.Transport;
public sealed class TransportOptions
{
    public required Uri Endpoint { get; init; }
    public string? ApiKey { get; init; }
}
