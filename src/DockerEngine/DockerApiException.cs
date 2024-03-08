using System;
using System.Collections.Generic;

namespace DockerEngine;

public class DockerApiException : Exception
{
    public DockerApiException(string message, int statusCode, string? responseText, IReadOnlyDictionary<string, IEnumerable<string>> headers, Exception? innerException)
        : base(message, innerException)
    {
        StatusCode = statusCode;
        ResponseText = responseText;
        Headers = headers;
    }

    public int StatusCode { get; }
    public string? ResponseText { get; }
    public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; }
}

public class DockerApiException<T> : DockerApiException
{
    public DockerApiException(string message, int statusCode, string? responseText, IReadOnlyDictionary<string, IEnumerable<string>> headers, T error, Exception? innerException)
        : base(message, statusCode, responseText, headers, innerException)
    {
        Error = error;
    }

    public T Error { get; }
}