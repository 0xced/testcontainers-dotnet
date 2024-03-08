using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
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
                return new SocketsHttpHandler { ConnectCallback = (_, ct) => TcpConnectAsync(dockerEndpoint, ct) };
            case "npipe":
                return new SocketsHttpHandler { ConnectCallback = (_, ct) => NamedPipeConnectAsync(dockerEndpoint, ct) };
            case "unix":
                return new SocketsHttpHandler { ConnectCallback = (_, ct) => UnixSocketConnectAsync(dockerEndpoint, ct) };
            default:
                throw new InvalidOperationException($"The Docker scheme {dockerEndpoint.Scheme} is not supported.");
        }
    }

    private static async ValueTask<Stream> TcpConnectAsync(Uri uri, CancellationToken ct)
    {
        var addresses = await Dns.GetHostAddressesAsync(uri.Host, ct).ConfigureAwait(false);
        if (addresses.Length == 0)
        {
            throw new DockerException($"DNS resolution failed for {uri.Host}");
        }

        return await ConnectAsync(addresses.Select(e => new IPEndPoint(e, uri.Port)), ProtocolType.Tcp, ct);
    }

    private static async ValueTask<Stream> ConnectAsync(IEnumerable<EndPoint> endPoints, ProtocolType protocol, CancellationToken ct)
    {
        var exceptions = new List<Exception>();
        foreach (var endPoint in endPoints)
        {
            var result = await TryConnectAsync(endPoint, protocol, ct);
            if (result.Socket != null)
            {
                return new NetworkStream(result.Socket, ownsSocket: true);
            }

            exceptions.Add(result.Exception);
        }

        if (exceptions.Count == 1)
            throw exceptions[0];

        throw new AggregateException(exceptions);
    }

    private static async Task<(Socket Socket, Exception Exception)> TryConnectAsync(EndPoint endPoint, ProtocolType protocol, CancellationToken ct)
    {
        var socket = new Socket(endPoint.AddressFamily, SocketType.Stream, protocol);
        try
        {
            await socket.ConnectAsync(endPoint, ct).ConfigureAwait(false);
            return (socket, null);
        }
        catch (Exception exception)
        {
            socket.Dispose();
            return (null, exception);
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
        return await ConnectAsync([new UnixDomainSocketEndPoint(uri.AbsolutePath)], ProtocolType.IP, ct);
    }
}