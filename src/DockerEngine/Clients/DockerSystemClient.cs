using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace DockerEngine;

[SuppressMessage("ReSharper", "InvocationIsSkipped")]
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DockerSystemClient : IDockerSystemClient
{
    private readonly HttpClient _httpClient;
    private static readonly Lazy<JsonSerializerOptions> _settings = new Lazy<JsonSerializerOptions>(CreateSerializerSettings, true);

    public DockerSystemClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    private static JsonSerializerOptions CreateSerializerSettings()
    {
        var settings = new System.Text.Json.JsonSerializerOptions();
        UpdateJsonSerializerSettings(settings);
        return settings;
    }


    protected JsonSerializerOptions JsonSerializerSettings => _settings.Value;

    static partial void UpdateJsonSerializerSettings(JsonSerializerOptions settings);


    partial void PrepareRequest(HttpClient client, HttpRequestMessage request, string url);
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request, StringBuilder urlBuilder);
    partial void ProcessResponse(HttpClient client, HttpResponseMessage response);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Check auth configuration
    /// </summary>
    /// <remarks>
    /// Validate credentials for a registry and, if available, get an identity
    /// <br/>token for accessing the registry without password.
    /// </remarks>
    /// <param name="authConfig">Authentication to check</param>
    /// <returns>An identity token was generated successfully.</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<Response> AuthAsync(AuthConfig? authConfig = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                var json = System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(authConfig, _settings.Value);
                var content = new ByteArrayContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "auth"
                urlBuilder.Append("auth");

                PrepareRequest(client, request, urlBuilder);

                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);

                PrepareRequest(client, request, url);

                var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse = true;
                try
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item in response.Headers)
                        headers[item.Key] = item.Value;
                    foreach (var item in response.Content.Headers)
                        headers[item.Key] = item.Value;

                    ProcessResponse(client, response);

                    var statusCode = (int)response.StatusCode;
                    if (statusCode == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<Response>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        return objectResponse.Object;
                    }
                    else
                    if (statusCode == 204)
                    {
                        string responseText = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        throw new DockerApiException("No error", statusCode, responseText, headers, null);
                    }
                    else
                    if (statusCode == 401)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("Auth error", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
                    }
                    else
                    if (statusCode == 500)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("Server error", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
                    }
                    else
                    {
                        var responseData = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        throw new DockerApiException("The HTTP statusCode code of the response was not expected (" + statusCode + ").", statusCode, responseData, headers, null);
                    }
                }
                finally
                {
                    if (disposeResponse)
                        response.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient)
                client.Dispose();
        }
    }


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get system information
    /// </summary>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<SystemInfo> InfoAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "info"
                urlBuilder.Append("info");

                PrepareRequest(client, request, urlBuilder);

                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);

                PrepareRequest(client, request, url);

                var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse = true;
                try
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item in response.Headers)
                        headers[item.Key] = item.Value;
                    foreach (var item in response.Content.Headers)
                        headers[item.Key] = item.Value;

                    ProcessResponse(client, response);

                    var statusCode = (int)response.StatusCode;
                    if (statusCode == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SystemInfo>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        return objectResponse.Object;
                    }
                    else
                    if (statusCode == 500)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("Server error", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
                    }
                    else
                    {
                        var responseData = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        throw new DockerApiException("The HTTP statusCode code of the response was not expected (" + statusCode + ").", statusCode, responseData, headers, null);
                    }
                }
                finally
                {
                    if (disposeResponse)
                        response.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient)
                client.Dispose();
        }
    }


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get version
    /// </summary>
    /// <remarks>
    /// Returns the version of Docker that is running and various information about the system that Docker is running on.
    /// </remarks>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<SystemVersion> VersionAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "version"
                urlBuilder.Append("version");

                PrepareRequest(client, request, urlBuilder);

                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);

                PrepareRequest(client, request, url);

                var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse = true;
                try
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item in response.Headers)
                        headers[item.Key] = item.Value;
                    foreach (var item in response.Content.Headers)
                        headers[item.Key] = item.Value;

                    ProcessResponse(client, response);

                    var statusCode = (int)response.StatusCode;
                    if (statusCode == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SystemVersion>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        return objectResponse.Object;
                    }
                    else
                    if (statusCode == 500)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("server error", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
                    }
                    else
                    {
                        var responseData = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        throw new DockerApiException("The HTTP statusCode code of the response was not expected (" + statusCode + ").", statusCode, responseData, headers, null);
                    }
                }
                finally
                {
                    if (disposeResponse)
                        response.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient)
                client.Dispose();
        }
    }


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Ping
    /// </summary>
    /// <remarks>
    /// This is a dummy endpoint you can use to test if the server is accessible.
    /// </remarks>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<string> PingAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "_ping"
                urlBuilder.Append("_ping");

                PrepareRequest(client, request, urlBuilder);

                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);

                PrepareRequest(client, request, url);

                var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse = true;
                try
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item in response.Headers)
                        headers[item.Key] = item.Value;
                    foreach (var item in response.Content.Headers)
                        headers[item.Key] = item.Value;

                    ProcessResponse(client, response);

                    var statusCode = (int)response.StatusCode;
                    if (statusCode == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<string>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        return objectResponse.Object;
                    }
                    else
                    if (statusCode == 500)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("server error", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
                    }
                    else
                    {
                        var responseData = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        throw new DockerApiException("The HTTP statusCode code of the response was not expected (" + statusCode + ").", statusCode, responseData, headers, null);
                    }
                }
                finally
                {
                    if (disposeResponse)
                        response.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient)
                client.Dispose();
        }
    }


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Ping
    /// </summary>
    /// <remarks>
    /// This is a dummy endpoint you can use to test if the server is accessible.
    /// </remarks>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<string> PingHeadAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("HEAD");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "_ping"
                urlBuilder.Append("_ping");

                PrepareRequest(client, request, urlBuilder);

                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);

                PrepareRequest(client, request, url);

                var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse = true;
                try
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item in response.Headers)
                        headers[item.Key] = item.Value;
                    foreach (var item in response.Content.Headers)
                        headers[item.Key] = item.Value;

                    ProcessResponse(client, response);

                    var statusCode = (int)response.StatusCode;
                    if (statusCode == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<string>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        return objectResponse.Object;
                    }
                    else
                    if (statusCode == 500)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("server error", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
                    }
                    else
                    {
                        var responseData = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        throw new DockerApiException("The HTTP statusCode code of the response was not expected (" + statusCode + ").", statusCode, responseData, headers, null);
                    }
                }
                finally
                {
                    if (disposeResponse)
                        response.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient)
                client.Dispose();
        }
    }


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Monitor events
    /// </summary>
    /// <remarks>
    /// Stream real-time events from the server.
    /// <br/>
    /// <br/>Various objects within Docker report events when something happens to them.
    /// <br/>
    /// <br/>Containers report these events: `attach`, `commit`, `copy`, `create`, `destroy`, `detach`, `die`, `exec_create`, `exec_detach`, `exec_start`, `exec_die`, `export`, `health_status`, `kill`, `oom`, `pause`, `rename`, `resize`, `restart`, `start`, `stop`, `top`, `unpause`, `update`, and `prune`
    /// <br/>
    /// <br/>Images report these events: `delete`, `import`, `load`, `pull`, `push`, `save`, `tag`, `untag`, and `prune`
    /// <br/>
    /// <br/>Volumes report these events: `create`, `mount`, `unmount`, `destroy`, and `prune`
    /// <br/>
    /// <br/>Networks report these events: `create`, `connect`, `disconnect`, `destroy`, `update`, `remove`, and `prune`
    /// <br/>
    /// <br/>The Docker daemon reports these events: `reload`
    /// <br/>
    /// <br/>Services report these events: `create`, `update`, and `remove`
    /// <br/>
    /// <br/>Nodes report these events: `create`, `update`, and `remove`
    /// <br/>
    /// <br/>Secrets report these events: `create`, `update`, and `remove`
    /// <br/>
    /// <br/>Configs report these events: `create`, `update`, and `remove`
    /// <br/>
    /// <br/>The Builder reports `prune` events
    /// </remarks>
    /// <param name="since">Show events created since this timestamp then stream new events.</param>
    /// <param name="until">Show events created until this timestamp then stop streaming.</param>
    /// <param name="filters">A JSON encoded value of filters (a `map[string][]string`) to process on the event list. Available filters:
    /// <br/>
    /// <br/>- `config=&lt;string&gt;` config name or ID
    /// <br/>- `container=&lt;string&gt;` container name or ID
    /// <br/>- `daemon=&lt;string&gt;` daemon name or ID
    /// <br/>- `event=&lt;string&gt;` event type
    /// <br/>- `image=&lt;string&gt;` image name or ID
    /// <br/>- `label=&lt;string&gt;` image or container label
    /// <br/>- `network=&lt;string&gt;` network name or ID
    /// <br/>- `node=&lt;string&gt;` node ID
    /// <br/>- `plugin`=&lt;string&gt; plugin name or ID
    /// <br/>- `scope`=&lt;string&gt; local or swarm
    /// <br/>- `secret=&lt;string&gt;` secret name or ID
    /// <br/>- `service=&lt;string&gt;` service name or ID
    /// <br/>- `type=&lt;string&gt;` object to filter by, one of `container`, `image`, `volume`, `network`, `daemon`, `plugin`, `node`, `service`, `secret` or `config`
    /// <br/>- `volume=&lt;string&gt;` volume name</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<EventMessage> EventsAsync(string? since = null, string? until = null, string? filters = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "events"
                urlBuilder.Append("events");
                urlBuilder.Append('?');
                if (since != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("since")).Append('=').Append(Uri.EscapeDataString(ConvertToString(since, CultureInfo.InvariantCulture))).Append('&');
                }
                if (until != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("until")).Append('=').Append(Uri.EscapeDataString(ConvertToString(until, CultureInfo.InvariantCulture))).Append('&');
                }
                if (filters != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("filters")).Append('=').Append(Uri.EscapeDataString(ConvertToString(filters, CultureInfo.InvariantCulture))).Append('&');
                }
                urlBuilder.Length--;

                PrepareRequest(client, request, urlBuilder);

                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);

                PrepareRequest(client, request, url);

                var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse = true;
                try
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item in response.Headers)
                        headers[item.Key] = item.Value;
                    foreach (var item in response.Content.Headers)
                        headers[item.Key] = item.Value;

                    ProcessResponse(client, response);

                    var statusCode = (int)response.StatusCode;
                    if (statusCode == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<EventMessage>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        return objectResponse.Object;
                    }
                    else
                    if (statusCode == 400)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("bad parameter", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
                    }
                    else
                    if (statusCode == 500)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("server error", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
                    }
                    else
                    {
                        var responseData = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        throw new DockerApiException("The HTTP statusCode code of the response was not expected (" + statusCode + ").", statusCode, responseData, headers, null);
                    }
                }
                finally
                {
                    if (disposeResponse)
                        response.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient)
                client.Dispose();
        }
    }


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get data usage information
    /// </summary>
    /// <param name="type">Object types, for which to compute and return data.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<SystemDataUsageResponse> DataUsageAsync(IEnumerable<Anonymous>? type = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "system/df"
                urlBuilder.Append("system/df");
                urlBuilder.Append('?');
                if (type != null)
                {
                    foreach (var item in type) { urlBuilder.Append(Uri.EscapeDataString("type")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item, CultureInfo.InvariantCulture))).Append('&'); }
                }
                urlBuilder.Length--;

                PrepareRequest(client, request, urlBuilder);

                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);

                PrepareRequest(client, request, url);

                var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                var disposeResponse = true;
                try
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item in response.Headers)
                        headers[item.Key] = item.Value;
                    foreach (var item in response.Content.Headers)
                        headers[item.Key] = item.Value;

                    ProcessResponse(client, response);

                    var statusCode = (int)response.StatusCode;
                    if (statusCode == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SystemDataUsageResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        return objectResponse.Object;
                    }
                    else
                    if (statusCode == 500)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("server error", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
                    }
                    else
                    {
                        var responseData = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        throw new DockerApiException("The HTTP statusCode code of the response was not expected (" + statusCode + ").", statusCode, responseData, headers, null);
                    }
                }
                finally
                {
                    if (disposeResponse)
                        response.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient)
                client.Dispose();
        }
    }


    protected struct ObjectResponseResult<T>
    {
        public ObjectResponseResult(T responseObject, string responseText)
        {
            Object = responseObject;
            Text = responseText;
        }

        public T Object { get; }

        public string Text { get; }
    }

    public bool ReadResponseAsString { get; set; }

    protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(System.Net.Http.HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
    {
        if (response?.Content == null)
        {
            return new ObjectResponseResult<T>(default!, string.Empty);
        }

        if (ReadResponseAsString)
        {
            var responseText = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
            try
            {
                var typedBody = System.Text.Json.JsonSerializer.Deserialize<T>(responseText, JsonSerializerSettings);
                return new ObjectResponseResult<T>(typedBody!, responseText);
            }
            catch (System.Text.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                throw new DockerApiException(message, (int)response.StatusCode, responseText, headers, exception);
            }
        }
        else
        {
            try
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false))
                {
                    var typedBody = await System.Text.Json.JsonSerializer.DeserializeAsync<T>(responseStream, JsonSerializerSettings, cancellationToken).ConfigureAwait(false);
                    return new ObjectResponseResult<T>(typedBody!, string.Empty);
                }
            }
            catch (System.Text.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                throw new DockerApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
            }
        }
    }

    private static string ConvertToString(object? value, CultureInfo cultureInfo)
    {
        if (value == null)
        {
            return "";
        }

        if (value is Enum)
        {
            var name = Enum.GetName(value.GetType(), value);
            if (name != null)
            {
                var field = value.GetType().GetTypeInfo().GetDeclaredField(name);
                if (field != null)
                {
                    var attribute = field.GetCustomAttribute<EnumMemberAttribute>();
                    if (attribute != null)
                    {
                        return attribute.Value ?? name;
                    }
                }

                var converted = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                return converted ?? "";
            }
        }
        else if (value is bool boolean) 
        {
            return Convert.ToString(boolean, cultureInfo).ToLowerInvariant();
        }
        else if (value is byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }
        else if (value is string[] values)
        {
            return string.Join(",", values);
        }
        else if (value is Array valueArray)
        {
            var valueTextArray = new string[valueArray.Length];
            for (var i = 0; i < valueArray.Length; i++)
            {
                valueTextArray[i] = ConvertToString(valueArray.GetValue(i), cultureInfo);
            }
            return string.Join(",", valueTextArray);
        }

        var result = Convert.ToString(value, cultureInfo);
        return result ?? "";
    }
}