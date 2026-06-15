using System.Net.Http.Json;
using Rimout.Contracts;

namespace Rimout.Agent.Transport;

public sealed class HttpTransport(HttpClient client, TransportOptions options):ITransport
{
    public async Task SendAsync(MetricBatch batch,CancellationToken cancellationToken)
    {
        using var request=new HttpRequestMessage(HttpMethod.Post,new Uri(options.Endpoint,"api/ingest"))
        {
            Content=JsonContent.Create(new IngestRequest(batch))
        };
        if(!string.IsNullOrWhiteSpace(options.ApiKey))
            request.Headers.Add("X-Api-Key",options.ApiKey);
        using var response=await client.SendAsync(request,cancellationToken);
        response.EnsureSuccessStatusCode();
    }
}
