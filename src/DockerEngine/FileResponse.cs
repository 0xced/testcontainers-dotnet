using System;
using System.Collections.Generic;
using System.IO;

namespace DockerEngine;

public class FileResponse : IDisposable
{
    private readonly IDisposable _response;

    public int StatusCode { get; }

    public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; }

    public Stream Stream { get; }

    public FileResponse(int statusCode, IReadOnlyDictionary<string, IEnumerable<string>> headers, Stream stream, IDisposable response)
    {
        StatusCode = statusCode;
        Headers = headers;
        Stream = stream;
        _response = response;
    }

    public void Dispose()
    {
        Stream.Dispose();
        _response.Dispose();
    }
}
