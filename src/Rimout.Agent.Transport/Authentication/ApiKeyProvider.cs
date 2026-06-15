namespace Rimout.Agent.Transport.Authentication;
public sealed class ApiKeyProvider
{
    public string? ApiKey { get; }
    public ApiKeyProvider(string? apiKey)=>ApiKey=apiKey;
}
