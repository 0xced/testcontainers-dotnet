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
public partial class DockerSecretClient : IDockerSecretClient
{
    private readonly HttpClient _httpClient;
    private static readonly Lazy<JsonSerializerOptions> _settings = new Lazy<JsonSerializerOptions>(CreateSerializerSettings, true);

    public DockerSecretClient(HttpClient httpClient)
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
    /// List secrets
    /// </summary>
    /// <param name="filters">A JSON encoded value of the filters (a `map[string][]string`) to
    /// <br/>process on the secrets list.
    /// <br/>
    /// <br/>Available filters:
    /// <br/>
    /// <br/>- `id=&lt;secret id&gt;`
    /// <br/>- `label=&lt;key&gt; or label=&lt;key&gt;=value`
    /// <br/>- `name=&lt;secret name&gt;`
    /// <br/>- `names=&lt;secret name&gt;`</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<IReadOnlyCollection<Secret>> ListAsync(string? filters = null, CancellationToken cancellationToken = default)
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
                
                // Operation Path: "secrets"
                urlBuilder.Append("secrets");
                urlBuilder.Append('?');
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
                        var objectResponse = await ReadObjectResponseAsync<IReadOnlyCollection<Secret>>(response, headers, cancellationToken).ConfigureAwait(false);
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
                    if (statusCode == 503)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("node is not part of a swarm", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
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
    /// Create a secret
    /// </summary>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<IdResponse> CreateAsync(Body5? body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                var content = new ByteArrayContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "secrets/create"
                urlBuilder.Append("secrets/create");

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
                    if (statusCode == 409)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("name conflicts with an existing object", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
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
                    if (statusCode == 503)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("node is not part of a swarm", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
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
    /// Inspect a secret
    /// </summary>
    /// <param name="id">ID of the secret</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<Secret> InspectAsync(string id, CancellationToken cancellationToken = default)
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
                
                // Operation Path: "secrets/{id}"
                urlBuilder.Append("secrets/");
                urlBuilder.Append(Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

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
                        var objectResponse = await ReadObjectResponseAsync<Secret>(response, headers, cancellationToken).ConfigureAwait(false);
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
                        throw new DockerApiException<ErrorResponse>("secret not found", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
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
                    if (statusCode == 503)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("node is not part of a swarm", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
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
    /// Delete a secret
    /// </summary>
    /// <param name="id">ID of the secret</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task DeleteAsync(string id, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(id);
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("DELETE");

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "secrets/{id}"
                urlBuilder.Append("secrets/");
                urlBuilder.Append(Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

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
                    if (statusCode == 204)
                    {
                        return;
                    }
                    else
                    if (statusCode == 404)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("secret not found", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
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
                    if (statusCode == 503)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("node is not part of a swarm", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
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
    /// Update a Secret
    /// </summary>
    /// <param name="id">The ID or name of the secret</param>
    /// <param name="version">The version number of the secret object being updated. This is
    /// <br/>required to avoid conflicting writes.</param>
    /// <param name="body">The spec of the secret to update. Currently, only the Labels field
    /// <br/>can be updated. All other fields must remain unchanged from the
    /// <br/>[SecretInspect endpoint](#operation/SecretInspect) response values.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task UpdateAsync(string id, long version, SecretSpec? body = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(id);
        ArgumentNullException.ThrowIfNull(version);
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                var content = new ByteArrayContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "secrets/{id}/update"
                urlBuilder.Append("secrets/");
                urlBuilder.Append(Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
                urlBuilder.Append("/update");
                urlBuilder.Append('?');
                urlBuilder.Append(Uri.EscapeDataString("version")).Append('=').Append(Uri.EscapeDataString(ConvertToString(version, CultureInfo.InvariantCulture))).Append('&');
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
                        throw new DockerApiException<ErrorResponse>("no such secret", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
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
                    if (statusCode == 503)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("node is not part of a swarm", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
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

    protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
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
                var typedBody = JsonSerializer.Deserialize<T>(responseText, JsonSerializerSettings);
                return new ObjectResponseResult<T>(typedBody!, responseText);
            }
            catch (JsonException exception)
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
                    var typedBody = await JsonSerializer.DeserializeAsync<T>(responseStream, JsonSerializerSettings, cancellationToken).ConfigureAwait(false);
                    return new ObjectResponseResult<T>(typedBody!, string.Empty);
                }
            }
            catch (JsonException exception)
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