namespace Rimout.Agent.Transport;
using Rimout.Contracts;
public interface ITransport
{
    Task SendAsync(MetricBatch batch, CancellationToken cancellationToken);
}
