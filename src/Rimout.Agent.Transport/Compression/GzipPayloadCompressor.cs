using System.IO.Compression;
namespace Rimout.Agent.Transport.Compression;
public static class GzipPayloadCompressor
{
    public static byte[] Compress(byte[] payload)
    {
        using var output=new MemoryStream();
        using(var gzip=new GZipStream(output,CompressionLevel.Fastest,true))
            gzip.Write(payload);
        return output.ToArray();
    }
}
