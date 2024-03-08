using System.IO;
using System.Net;
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
                return new NamedPipeMessageHandler();
            case "unix":
                return new SocketsHttpHandler { ConnectCallback = (_, ct) => UnixSocketConnectAsync(new UnixDomainSocketEndPoint(dockerEndpoint.AbsolutePath), ct) };
            default:
                throw new InvalidOperationException($"The Docker scheme {dockerEndpoint.Scheme} is not supported.");
        }
    }

    private static async ValueTask<Stream> UnixSocketConnectAsync(EndPoint endPoint, CancellationToken ct)
    {
        var socket = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.IP);
        await socket.ConnectAsync(endPoint, ct);
        return new NetworkStream(socket, ownsSocket: true);
    }
}