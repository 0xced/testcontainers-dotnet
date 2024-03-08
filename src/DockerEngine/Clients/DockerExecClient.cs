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
public partial class DockerExecClient : IDockerExecClient
{
    private readonly HttpClient _httpClient;
    private static readonly Lazy<JsonSerializerOptions> _settings = new Lazy<JsonSerializerOptions>(CreateSerializerSettings, true);

    public DockerExecClient(HttpClient httpClient)
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
    /// Create an exec instance
    /// </summary>
    /// <remarks>
    /// Run a command inside a running container.
    /// </remarks>
    /// <param name="execConfig">Exec configuration</param>
    /// <param name="id">ID or name of container</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<IdResponse> ContainerExecAsync(ExecConfig execConfig, string id, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(id);
        ArgumentNullException.ThrowIfNull(execConfig);
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                var json = System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(execConfig, _settings.Value);
                var content = new ByteArrayContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "containers/{id}/exec"
                urlBuilder.Append("containers/");
                urlBuilder.Append(Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
                urlBuilder.Append("/exec");

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
                    if (statusCode == 201)
                    {
                        var objectResponse = await ReadObjectResponseAsync<IdResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        return objectResponse.Object;
                    }
                    else
                    if (statusCode == 404)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("no such container", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
                    }
                    else
                    if (statusCode == 409)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("container is paused", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
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
    /// Start an exec instance
    /// </summary>
    /// <remarks>
    /// Starts a previously set up exec instance. If detach is true, this endpoint
    /// <br/>returns immediately after starting the command. Otherwise, it sets up an
    /// <br/>interactive session with the command.
    /// </remarks>
    /// <param name="id">Exec instance ID</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<FileResponse> StartAsync(string id, ExecStartConfig? execStartConfig = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(id);
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                var json = System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(execStartConfig, _settings.Value);
                var content = new ByteArrayContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/vnd.docker.raw-stream"));

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "exec/{id}/start"
                urlBuilder.Append("exec/");
                urlBuilder.Append(Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
                urlBuilder.Append("/start");

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
                    if (statusCode == 200 || statusCode == 206)
                    {
                        return default(FileResponse)!;
                    }
                    else
                    if (statusCode == 404)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("No such exec instance", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
                    }
                    else
                    if (statusCode == 409)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("Container is stopped or paused", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
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
    /// Resize an exec instance
    /// </summary>
    /// <remarks>
    /// Resize the TTY session used by an exec instance. This endpoint only works
    /// <br/>if `tty` was specified as part of creating and starting the exec instance.
    /// </remarks>
    /// <param name="id">Exec instance ID</param>
    /// <param name="h">Height of the TTY session in characters</param>
    /// <param name="w">Width of the TTY session in characters</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task ResizeAsync(string id, int? h = null, int? w = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(id);
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                request.Method = new HttpMethod("POST");

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "exec/{id}/resize"
                urlBuilder.Append("exec/");
                urlBuilder.Append(Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
                urlBuilder.Append("/resize");
                urlBuilder.Append('?');
                if (h != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("h")).Append('=').Append(Uri.EscapeDataString(ConvertToString(h, CultureInfo.InvariantCulture))).Append('&');
                }
                if (w != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("w")).Append('=').Append(Uri.EscapeDataString(ConvertToString(w, CultureInfo.InvariantCulture))).Append('&');
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
                        return;
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
                    if (statusCode == 404)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("No such exec instance", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
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
    /// Inspect an exec instance
    /// </summary>
    /// <remarks>
    /// Return low-level information about an exec instance.
    /// </remarks>
    /// <param name="id">Exec instance ID</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<ExecInspectResponse> InspectAsync(string id, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(id);
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "exec/{id}/json"
                urlBuilder.Append("exec/");
                urlBuilder.Append(Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
                urlBuilder.Append("/json");

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
                        var objectResponse = await ReadObjectResponseAsync<ExecInspectResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        return objectResponse.Object;
                    }
                    else
                    if (statusCode == 404)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("No such exec instance", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
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