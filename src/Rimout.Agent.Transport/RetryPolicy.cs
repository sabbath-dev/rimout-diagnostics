namespace Rimout.Agent.Transport;
public sealed class RetryPolicy
{
    public int MaxRetries { get; init; }=5;
    public TimeSpan BaseDelay { get; init; }=TimeSpan.FromSeconds(2);
}
