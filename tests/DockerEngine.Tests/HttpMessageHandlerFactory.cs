using System.IO;
using System.IO.Pipes;
using System.Net.Sockets;

namespace DockerEngine;

internal static class HttpMessageHandlerFactory
{
    public static HttpMessageHandler GetHttpMessageHandler(Uri dockerEndpoint)
    {
        switch (dockerEndpoint.Scheme)
        {
            case "http":
            case "https":
                return new HttpClientHandler();
            case "tcp":
                return new HttpClientHandler();
            case "npipe":
                return new SocketsHttpHandler { ConnectCallback = (_, ct) => NamedPipeConnectAsync(dockerEndpoint, ct) };
            case "unix":
                return new SocketsHttpHandler { ConnectCallback = (_, ct) => UnixSocketConnectAsync(dockerEndpoint, ct) };
            default:
                throw new InvalidOperationException($"The Docker scheme {dockerEndpoint.Scheme} is not supported.");
        }
    }

    private static async ValueTask<Stream> NamedPipeConnectAsync(Uri uri, CancellationToken ct)
    {
        var pipeName = uri.AbsolutePath.StartsWith("/pipe/") ? uri.AbsolutePath[6..] : uri.AbsolutePath;
        var stream = new NamedPipeClientStream(uri.Host, pipeName, PipeDirection.InOut, PipeOptions.Asynchronous);
        await stream.ConnectAsync(ct);
        return stream;
    }

    private static async ValueTask<Stream> UnixSocketConnectAsync(Uri uri, CancellationToken ct)
    {
        var socket = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.IP);
        await socket.ConnectAsync(new UnixDomainSocketEndPoint(uri.AbsolutePath), ct);
        return new NetworkStream(socket, ownsSocket: true);
    }
}