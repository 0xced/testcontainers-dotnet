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
public partial class DockerImageClient : IDockerImageClient
{
    private readonly HttpClient _httpClient;
    private static readonly Lazy<JsonSerializerOptions> _settings = new Lazy<JsonSerializerOptions>(CreateSerializerSettings, true);

    public DockerImageClient(HttpClient httpClient)
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
    /// List Images
    /// </summary>
    /// <remarks>
    /// Returns a list of images on the server. Note that it uses a different, smaller representation of an image than inspecting a single image.
    /// </remarks>
    /// <param name="all">Show all images. Only images from a final layer (no children) are shown by default.</param>
    /// <param name="filters">A JSON encoded value of the filters (a `map[string][]string`) to
    /// <br/>process on the images list.
    /// <br/>
    /// <br/>Available filters:
    /// <br/>
    /// <br/>- `before`=(`&lt;image-name&gt;[:&lt;tag&gt;]`,  `&lt;image id&gt;` or `&lt;image@digest&gt;`)
    /// <br/>- `dangling=true`
    /// <br/>- `label=key` or `label="key=value"` of an image label
    /// <br/>- `reference`=(`&lt;image-name&gt;[:&lt;tag&gt;]`)
    /// <br/>- `since`=(`&lt;image-name&gt;[:&lt;tag&gt;]`,  `&lt;image id&gt;` or `&lt;image@digest&gt;`)
    /// <br/>- `until=&lt;timestamp&gt;`</param>
    /// <param name="shared_size">Compute and show shared size as a `SharedSize` field on each image.</param>
    /// <param name="digests">Show digest information as a `RepoDigests` field on each image.</param>
    /// <returns>Summary image data for the images matching the query</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<IReadOnlyCollection<ImageSummary>> ListAsync(bool? all = null, string? filters = null, bool? shared_size = null, bool? digests = null, CancellationToken cancellationToken = default)
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
                
                // Operation Path: "images/json"
                urlBuilder.Append("images/json");
                urlBuilder.Append('?');
                if (all != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("all")).Append('=').Append(Uri.EscapeDataString(ConvertToString(all, CultureInfo.InvariantCulture))).Append('&');
                }
                if (filters != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("filters")).Append('=').Append(Uri.EscapeDataString(ConvertToString(filters, CultureInfo.InvariantCulture))).Append('&');
                }
                if (shared_size != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("shared-size")).Append('=').Append(Uri.EscapeDataString(ConvertToString(shared_size, CultureInfo.InvariantCulture))).Append('&');
                }
                if (digests != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("digests")).Append('=').Append(Uri.EscapeDataString(ConvertToString(digests, CultureInfo.InvariantCulture))).Append('&');
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
                        var objectResponse = await ReadObjectResponseAsync<IReadOnlyCollection<ImageSummary>>(response, headers, cancellationToken).ConfigureAwait(false);
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
    /// Build an image
    /// </summary>
    /// <remarks>
    /// Build an image from a tar archive with a `Dockerfile` in it.
    /// <br/>
    /// <br/>The `Dockerfile` specifies how the image is built from the tar archive. It is typically in the archive's root, but can be at a different path or have a different name by specifying the `dockerfile` parameter. [See the `Dockerfile` reference for more information](https://docs.docker.com/engine/reference/builder/).
    /// <br/>
    /// <br/>The Docker daemon performs a preliminary validation of the `Dockerfile` before starting the build, and returns an error if the syntax is incorrect. After that, each instruction is run one-by-one until the ID of the new image is output.
    /// <br/>
    /// <br/>The build is canceled if the client drops the connection by quitting or being killed.
    /// </remarks>
    /// <param name="inputStream">A tar archive compressed with one of the following algorithms: identity (no compression), gzip, bzip2, xz.</param>
    /// <param name="dockerfile">Path within the build context to the `Dockerfile`. This is ignored if `remote` is specified and points to an external `Dockerfile`.</param>
    /// <param name="t">A name and optional tag to apply to the image in the `name:tag` format. If you omit the tag the default `latest` value is assumed. You can provide several `t` parameters.</param>
    /// <param name="extrahosts">Extra hosts to add to /etc/hosts</param>
    /// <param name="remote">A Git repository URI or HTTP/HTTPS context URI. If the URI points to a single text file, the file’s contents are placed into a file called `Dockerfile` and the image is built from that file. If the URI points to a tarball, the file is downloaded by the daemon and the contents therein used as the context for the build. If the URI points to a tarball and the `dockerfile` parameter is also specified, there must be a file with the corresponding path inside the tarball.</param>
    /// <param name="q">Suppress verbose build output.</param>
    /// <param name="nocache">Do not use the cache when building the image.</param>
    /// <param name="cachefrom">JSON array of images used for build cache resolution.</param>
    /// <param name="pull">Attempt to pull the image even if an older image exists locally.</param>
    /// <param name="rm">Remove intermediate containers after a successful build.</param>
    /// <param name="forcerm">Always remove intermediate containers, even upon failure.</param>
    /// <param name="memory">Set memory limit for build.</param>
    /// <param name="memswap">Total memory (memory + swap). Set as `-1` to disable swap.</param>
    /// <param name="cpushares">CPU shares (relative weight).</param>
    /// <param name="cpusetcpus">CPUs in which to allow execution (e.g., `0-3`, `0,1`).</param>
    /// <param name="cpuperiod">The length of a CPU period in microseconds.</param>
    /// <param name="cpuquota">Microseconds of CPU time that the container can get in a CPU period.</param>
    /// <param name="buildargs">JSON map of string pairs for build-time variables. Users pass these values at build-time. Docker uses the buildargs as the environment context for commands run via the `Dockerfile` RUN instruction, or for variable expansion in other `Dockerfile` instructions. This is not meant for passing secret values.
    /// <br/>
    /// <br/>For example, the build arg `FOO=bar` would become `{"FOO":"bar"}` in JSON. This would result in the query parameter `buildargs={"FOO":"bar"}`. Note that `{"FOO":"bar"}` should be URI component encoded.
    /// <br/>
    /// <br/>[Read more about the buildargs instruction.](https://docs.docker.com/engine/reference/builder/#arg)</param>
    /// <param name="shmsize">Size of `/dev/shm` in bytes. The size must be greater than 0. If omitted the system uses 64MB.</param>
    /// <param name="squash">Squash the resulting images layers into a single layer. *(Experimental release only.)*</param>
    /// <param name="labels">Arbitrary key/value labels to set on the image, as a JSON map of string pairs.</param>
    /// <param name="networkmode">Sets the networking mode for the run commands during build. Supported
    /// <br/>standard values are: `bridge`, `host`, `none`, and `container:&lt;name|id&gt;`.
    /// <br/>Any other value is taken as a custom network's name or ID to which this
    /// <br/>container should connect to.</param>
    /// <param name="x_Registry_Config">This is a base64-encoded JSON object with auth configurations for multiple registries that a build may refer to.
    /// <br/>
    /// <br/>The key is a registry URL, and the value is an auth configuration object, [as described in the authentication section](#section/Authentication). For example:
    /// <br/>
    /// <br/>```
    /// <br/>{
    /// <br/>  "docker.example.com": {
    /// <br/>    "username": "janedoe",
    /// <br/>    "password": "hunter2"
    /// <br/>  },
    /// <br/>  "https://index.docker.io/v1/": {
    /// <br/>    "username": "mobydock",
    /// <br/>    "password": "conta1n3rize14"
    /// <br/>  }
    /// <br/>}
    /// <br/>```
    /// <br/>
    /// <br/>Only the registry domain name (and port if not the default 443) are required. However, for legacy reasons, the Docker Hub registry must be specified with both a `https://` prefix and a `/v1/` suffix even though Docker will prefer to use the v2 registry API.</param>
    /// <param name="platform">Platform in the format os[/arch[/variant]]</param>
    /// <param name="target">Target build stage</param>
    /// <param name="outputs">BuildKit output configuration</param>
    /// <param name="version">Version of the builder backend to use.
    /// <br/>
    /// <br/>- `1` is the first generation classic (deprecated) builder in the Docker daemon (default)
    /// <br/>- `2` is [BuildKit](https://github.com/moby/buildkit)</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task BuildAsync(Stream inputStream = null, string? dockerfile = null, string? t = null, string? extrahosts = null, string? remote = null, bool? q = null, bool? nocache = null, string? cachefrom = null, string? pull = null, bool? rm = null, bool? forcerm = null, int? memory = null, int? memswap = null, int? cpushares = null, string? cpusetcpus = null, int? cpuperiod = null, int? cpuquota = null, string? buildargs = null, int? shmsize = null, bool? squash = null, string? labels = null, string? networkmode = null, ContentType? content_type = null, string? x_Registry_Config = null, string? platform = null, string? target = null, string? outputs = null, Version? version = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {

                if (content_type != null)
                    request.Headers.TryAddWithoutValidation("Content-type", ConvertToString(content_type, CultureInfo.InvariantCulture));

                if (x_Registry_Config != null)
                    request.Headers.TryAddWithoutValidation("X-Registry-Config", ConvertToString(x_Registry_Config, CultureInfo.InvariantCulture));
                var content = new StreamContent(inputStream);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/octet-stream");
                request.Content = content;
                request.Method = new HttpMethod("POST");

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "build"
                urlBuilder.Append("build");
                urlBuilder.Append('?');
                if (dockerfile != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("dockerfile")).Append('=').Append(Uri.EscapeDataString(ConvertToString(dockerfile, CultureInfo.InvariantCulture))).Append('&');
                }
                if (t != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("t")).Append('=').Append(Uri.EscapeDataString(ConvertToString(t, CultureInfo.InvariantCulture))).Append('&');
                }
                if (extrahosts != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("extrahosts")).Append('=').Append(Uri.EscapeDataString(ConvertToString(extrahosts, CultureInfo.InvariantCulture))).Append('&');
                }
                if (remote != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("remote")).Append('=').Append(Uri.EscapeDataString(ConvertToString(remote, CultureInfo.InvariantCulture))).Append('&');
                }
                if (q != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("q")).Append('=').Append(Uri.EscapeDataString(ConvertToString(q, CultureInfo.InvariantCulture))).Append('&');
                }
                if (nocache != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("nocache")).Append('=').Append(Uri.EscapeDataString(ConvertToString(nocache, CultureInfo.InvariantCulture))).Append('&');
                }
                if (cachefrom != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("cachefrom")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cachefrom, CultureInfo.InvariantCulture))).Append('&');
                }
                if (pull != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("pull")).Append('=').Append(Uri.EscapeDataString(ConvertToString(pull, CultureInfo.InvariantCulture))).Append('&');
                }
                if (rm != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("rm")).Append('=').Append(Uri.EscapeDataString(ConvertToString(rm, CultureInfo.InvariantCulture))).Append('&');
                }
                if (forcerm != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("forcerm")).Append('=').Append(Uri.EscapeDataString(ConvertToString(forcerm, CultureInfo.InvariantCulture))).Append('&');
                }
                if (memory != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("memory")).Append('=').Append(Uri.EscapeDataString(ConvertToString(memory, CultureInfo.InvariantCulture))).Append('&');
                }
                if (memswap != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("memswap")).Append('=').Append(Uri.EscapeDataString(ConvertToString(memswap, CultureInfo.InvariantCulture))).Append('&');
                }
                if (cpushares != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("cpushares")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cpushares, CultureInfo.InvariantCulture))).Append('&');
                }
                if (cpusetcpus != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("cpusetcpus")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cpusetcpus, CultureInfo.InvariantCulture))).Append('&');
                }
                if (cpuperiod != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("cpuperiod")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cpuperiod, CultureInfo.InvariantCulture))).Append('&');
                }
                if (cpuquota != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("cpuquota")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cpuquota, CultureInfo.InvariantCulture))).Append('&');
                }
                if (buildargs != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("buildargs")).Append('=').Append(Uri.EscapeDataString(ConvertToString(buildargs, CultureInfo.InvariantCulture))).Append('&');
                }
                if (shmsize != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("shmsize")).Append('=').Append(Uri.EscapeDataString(ConvertToString(shmsize, CultureInfo.InvariantCulture))).Append('&');
                }
                if (squash != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("squash")).Append('=').Append(Uri.EscapeDataString(ConvertToString(squash, CultureInfo.InvariantCulture))).Append('&');
                }
                if (labels != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("labels")).Append('=').Append(Uri.EscapeDataString(ConvertToString(labels, CultureInfo.InvariantCulture))).Append('&');
                }
                if (networkmode != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("networkmode")).Append('=').Append(Uri.EscapeDataString(ConvertToString(networkmode, CultureInfo.InvariantCulture))).Append('&');
                }
                if (platform != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("platform")).Append('=').Append(Uri.EscapeDataString(ConvertToString(platform, CultureInfo.InvariantCulture))).Append('&');
                }
                if (target != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("target")).Append('=').Append(Uri.EscapeDataString(ConvertToString(target, CultureInfo.InvariantCulture))).Append('&');
                }
                if (outputs != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("outputs")).Append('=').Append(Uri.EscapeDataString(ConvertToString(outputs, CultureInfo.InvariantCulture))).Append('&');
                }
                if (version != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("version")).Append('=').Append(Uri.EscapeDataString(ConvertToString(version, CultureInfo.InvariantCulture))).Append('&');
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
                        throw new DockerApiException<ErrorResponse>("Bad parameter", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
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
    /// Delete builder cache
    /// </summary>
    /// <param name="keep_storage">Amount of disk space in bytes to keep for cache</param>
    /// <param name="all">Remove all types of build cache</param>
    /// <param name="filters">A JSON encoded value of the filters (a `map[string][]string`) to
    /// <br/>process on the list of build cache objects.
    /// <br/>
    /// <br/>Available filters:
    /// <br/>
    /// <br/>- `until=&lt;timestamp&gt;` remove cache older than `&lt;timestamp&gt;`. The `&lt;timestamp&gt;` can be Unix timestamps, date formatted timestamps, or Go duration strings (e.g. `10m`, `1h30m`) computed relative to the daemon's local time.
    /// <br/>- `id=&lt;id&gt;`
    /// <br/>- `parent=&lt;id&gt;`
    /// <br/>- `type=&lt;string&gt;`
    /// <br/>- `description=&lt;string&gt;`
    /// <br/>- `inuse`
    /// <br/>- `shared`
    /// <br/>- `private`</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<BuildPruneResponse> BuildPruneAsync(long? keep_storage = null, bool? all = null, string? filters = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "build/prune"
                urlBuilder.Append("build/prune");
                urlBuilder.Append('?');
                if (keep_storage != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("keep-storage")).Append('=').Append(Uri.EscapeDataString(ConvertToString(keep_storage, CultureInfo.InvariantCulture))).Append('&');
                }
                if (all != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("all")).Append('=').Append(Uri.EscapeDataString(ConvertToString(all, CultureInfo.InvariantCulture))).Append('&');
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
                        var objectResponse = await ReadObjectResponseAsync<BuildPruneResponse>(response, headers, cancellationToken).ConfigureAwait(false);
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
    /// Create an image
    /// </summary>
    /// <remarks>
    /// Pull or import an image.
    /// </remarks>
    /// <param name="fromImage">Name of the image to pull. The name may include a tag or digest. This parameter may only be used when pulling an image. The pull is cancelled if the HTTP connection is closed.</param>
    /// <param name="fromSrc">Source to import. The value may be a URL from which the image can be retrieved or `-` to read the image from the request body. This parameter may only be used when importing an image.</param>
    /// <param name="repo">Repository name given to an image when it is imported. The repo may include a tag. This parameter may only be used when importing an image.</param>
    /// <param name="tag">Tag or digest. If empty when pulling an image, this causes all tags for the given image to be pulled.</param>
    /// <param name="message">Set commit message for imported image.</param>
    /// <param name="inputImage">Image content if the value `-` has been specified in fromSrc query parameter</param>
    /// <param name="x_Registry_Auth">A base64url-encoded auth configuration.
    /// <br/>
    /// <br/>Refer to the [authentication section](#section/Authentication) for
    /// <br/>details.</param>
    /// <param name="changes">Apply `Dockerfile` instructions to the image that is created,
    /// <br/>for example: `changes=ENV DEBUG=true`.
    /// <br/>Note that `ENV DEBUG=true` should be URI component encoded.
    /// <br/>
    /// <br/>Supported `Dockerfile` instructions:
    /// <br/>`CMD`|`ENTRYPOINT`|`ENV`|`EXPOSE`|`ONBUILD`|`USER`|`VOLUME`|`WORKDIR`</param>
    /// <param name="platform">Platform in the format os[/arch[/variant]].
    /// <br/>
    /// <br/>When used in combination with the `fromImage` option, the daemon checks
    /// <br/>if the given image is present in the local image cache with the given
    /// <br/>OS and Architecture, and otherwise attempts to pull the image. If the
    /// <br/>option is not set, the host's native OS and Architecture are used.
    /// <br/>If the given image does not exist in the local image cache, the daemon
    /// <br/>attempts to pull the image with the host's native OS and Architecture.
    /// <br/>If the given image does exists in the local image cache, but its OS or
    /// <br/>architecture does not match, a warning is produced.
    /// <br/>
    /// <br/>When used with the `fromSrc` option to import an image from an archive,
    /// <br/>this option sets the platform information for the imported image. If
    /// <br/>the option is not set, the host's native OS and Architecture are used
    /// <br/>for the imported image.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task CreateAsync(string? fromImage = null, string? fromSrc = null, string? repo = null, string? tag = null, string? message = null, string? inputImage = null, string? x_Registry_Auth = null, IEnumerable<string>? changes = null, string? platform = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {

                if (x_Registry_Auth != null)
                    request.Headers.TryAddWithoutValidation("X-Registry-Auth", ConvertToString(x_Registry_Auth, CultureInfo.InvariantCulture));
                var content = new StringContent(inputImage);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("text/plain");
                request.Content = content;
                request.Method = new HttpMethod("POST");

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "images/create"
                urlBuilder.Append("images/create");
                urlBuilder.Append('?');
                if (fromImage != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("fromImage")).Append('=').Append(Uri.EscapeDataString(ConvertToString(fromImage, CultureInfo.InvariantCulture))).Append('&');
                }
                if (fromSrc != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("fromSrc")).Append('=').Append(Uri.EscapeDataString(ConvertToString(fromSrc, CultureInfo.InvariantCulture))).Append('&');
                }
                if (repo != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("repo")).Append('=').Append(Uri.EscapeDataString(ConvertToString(repo, CultureInfo.InvariantCulture))).Append('&');
                }
                if (tag != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("tag")).Append('=').Append(Uri.EscapeDataString(ConvertToString(tag, CultureInfo.InvariantCulture))).Append('&');
                }
                if (message != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("message")).Append('=').Append(Uri.EscapeDataString(ConvertToString(message, CultureInfo.InvariantCulture))).Append('&');
                }
                if (changes != null)
                {
                    foreach (var item in changes) { urlBuilder.Append(Uri.EscapeDataString("changes")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item, CultureInfo.InvariantCulture))).Append('&'); }
                }
                if (platform != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("platform")).Append('=').Append(Uri.EscapeDataString(ConvertToString(platform, CultureInfo.InvariantCulture))).Append('&');
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
                    if (statusCode == 404)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("repository does not exist or no read access", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
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
    /// Inspect an image
    /// </summary>
    /// <remarks>
    /// Return low-level information about an image.
    /// </remarks>
    /// <param name="name">Image name or id</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<ImageInspect> InspectAsync(string name, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(name);
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "images/{name}/json"
                urlBuilder.Append("images/");
                urlBuilder.Append(Uri.EscapeDataString(ConvertToString(name, CultureInfo.InvariantCulture)));
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
                        var objectResponse = await ReadObjectResponseAsync<ImageInspect>(response, headers, cancellationToken).ConfigureAwait(false);
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
                        throw new DockerApiException<ErrorResponse>("No such image", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
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
    /// Get the history of an image
    /// </summary>
    /// <remarks>
    /// Return parent layers of an image.
    /// </remarks>
    /// <param name="name">Image name or ID</param>
    /// <returns>List of image layers</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<IReadOnlyCollection<HistoryResponseItem>> HistoryAsync(string name, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(name);
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "images/{name}/history"
                urlBuilder.Append("images/");
                urlBuilder.Append(Uri.EscapeDataString(ConvertToString(name, CultureInfo.InvariantCulture)));
                urlBuilder.Append("/history");

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
                        var objectResponse = await ReadObjectResponseAsync<IReadOnlyCollection<HistoryResponseItem>>(response, headers, cancellationToken).ConfigureAwait(false);
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
                        throw new DockerApiException<ErrorResponse>("No such image", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
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
    /// Push an image
    /// </summary>
    /// <remarks>
    /// Push an image to a registry.
    /// <br/>
    /// <br/>If you wish to push an image on to a private registry, that image must
    /// <br/>already have a tag which references the registry. For example,
    /// <br/>`registry.example.com/myimage:latest`.
    /// <br/>
    /// <br/>The push is cancelled if the HTTP connection is closed.
    /// </remarks>
    /// <param name="name">Image name or ID.</param>
    /// <param name="x_Registry_Auth">A base64url-encoded auth configuration.
    /// <br/>
    /// <br/>Refer to the [authentication section](#section/Authentication) for
    /// <br/>details.</param>
    /// <param name="tag">The tag to associate with the image on the registry.</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task PushAsync(string name, string x_Registry_Auth, string? tag = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(name);
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {

                if (x_Registry_Auth == null)
                    throw new System.ArgumentNullException("x_Registry_Auth");
                request.Headers.TryAddWithoutValidation("X-Registry-Auth", ConvertToString(x_Registry_Auth, CultureInfo.InvariantCulture));
                request.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                request.Method = new HttpMethod("POST");

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "images/{name}/push"
                urlBuilder.Append("images/");
                urlBuilder.Append(Uri.EscapeDataString(ConvertToString(name, CultureInfo.InvariantCulture)));
                urlBuilder.Append("/push");
                urlBuilder.Append('?');
                if (tag != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("tag")).Append('=').Append(Uri.EscapeDataString(ConvertToString(tag, CultureInfo.InvariantCulture))).Append('&');
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
                    if (statusCode == 404)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("No such image", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
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
    /// Tag an image
    /// </summary>
    /// <remarks>
    /// Tag an image so that it becomes part of a repository.
    /// </remarks>
    /// <param name="name">Image name or ID to tag.</param>
    /// <param name="repo">The repository to tag in. For example, `someuser/someimage`.</param>
    /// <param name="tag">The name of the new tag.</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task TagAsync(string name, string? repo = null, string? tag = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(name);
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                request.Method = new HttpMethod("POST");

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "images/{name}/tag"
                urlBuilder.Append("images/");
                urlBuilder.Append(Uri.EscapeDataString(ConvertToString(name, CultureInfo.InvariantCulture)));
                urlBuilder.Append("/tag");
                urlBuilder.Append('?');
                if (repo != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("repo")).Append('=').Append(Uri.EscapeDataString(ConvertToString(repo, CultureInfo.InvariantCulture))).Append('&');
                }
                if (tag != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("tag")).Append('=').Append(Uri.EscapeDataString(ConvertToString(tag, CultureInfo.InvariantCulture))).Append('&');
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
                    if (statusCode == 201)
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
                        throw new DockerApiException<ErrorResponse>("Bad parameter", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
                    }
                    else
                    if (statusCode == 404)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("No such image", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
                    }
                    else
                    if (statusCode == 409)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("Conflict", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
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
    /// Remove an image
    /// </summary>
    /// <remarks>
    /// Remove an image, along with any untagged parent images that were
    /// <br/>referenced by that image.
    /// <br/>
    /// <br/>Images can't be removed if they have descendant images, are being
    /// <br/>used by a running container or are being used by a build.
    /// </remarks>
    /// <param name="name">Image name or ID</param>
    /// <param name="force">Remove the image even if it is being used by stopped containers or has other tags</param>
    /// <param name="noprune">Do not delete untagged parent images</param>
    /// <returns>The image was deleted successfully</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<IReadOnlyCollection<ImageDeleteResponseItem>> DeleteAsync(string name, bool? force = null, bool? noprune = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(name);
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("DELETE");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "images/{name}"
                urlBuilder.Append("images/");
                urlBuilder.Append(Uri.EscapeDataString(ConvertToString(name, CultureInfo.InvariantCulture)));
                urlBuilder.Append('?');
                if (force != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("force")).Append('=').Append(Uri.EscapeDataString(ConvertToString(force, CultureInfo.InvariantCulture))).Append('&');
                }
                if (noprune != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("noprune")).Append('=').Append(Uri.EscapeDataString(ConvertToString(noprune, CultureInfo.InvariantCulture))).Append('&');
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
                        var objectResponse = await ReadObjectResponseAsync<IReadOnlyCollection<ImageDeleteResponseItem>>(response, headers, cancellationToken).ConfigureAwait(false);
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
                        throw new DockerApiException<ErrorResponse>("No such image", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
                    }
                    else
                    if (statusCode == 409)
                    {
                        var objectResponse = await ReadObjectResponseAsync<ErrorResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                        if (objectResponse.Object == null)
                        {
                            throw new DockerApiException("Response was null which was not expected.", statusCode, objectResponse.Text, headers, null);
                        }
                        throw new DockerApiException<ErrorResponse>("Conflict", statusCode, objectResponse.Text, headers, objectResponse.Object, null);
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
    /// Search images
    /// </summary>
    /// <remarks>
    /// Search for an image on Docker Hub.
    /// </remarks>
    /// <param name="term">Term to search</param>
    /// <param name="limit">Maximum number of results to return</param>
    /// <param name="filters">A JSON encoded value of the filters (a `map[string][]string`) to process on the images list. Available filters:
    /// <br/>
    /// <br/>- `is-automated=(true|false)` (deprecated, see below)
    /// <br/>- `is-official=(true|false)`
    /// <br/>- `stars=&lt;number&gt;` Matches images that has at least 'number' stars.
    /// <br/>
    /// <br/>The `is-automated` filter is deprecated. The `is_automated` field has
    /// <br/>been deprecated by Docker Hub's search API. Consequently, searching
    /// <br/>for `is-automated=true` will yield no results.</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<IReadOnlyCollection<ImageSearchResponseItem>> SearchAsync(string term, int? limit = null, string? filters = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(term);
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "images/search"
                urlBuilder.Append("images/search");
                urlBuilder.Append('?');
                urlBuilder.Append(Uri.EscapeDataString("term")).Append('=').Append(Uri.EscapeDataString(ConvertToString(term, CultureInfo.InvariantCulture))).Append('&');
                if (limit != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("limit")).Append('=').Append(Uri.EscapeDataString(ConvertToString(limit, CultureInfo.InvariantCulture))).Append('&');
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
                        var objectResponse = await ReadObjectResponseAsync<IReadOnlyCollection<ImageSearchResponseItem>>(response, headers, cancellationToken).ConfigureAwait(false);
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
    /// Delete unused images
    /// </summary>
    /// <param name="filters">Filters to process on the prune list, encoded as JSON (a `map[string][]string`). Available filters:
    /// <br/>
    /// <br/>- `dangling=&lt;boolean&gt;` When set to `true` (or `1`), prune only
    /// <br/>   unused *and* untagged images. When set to `false`
    /// <br/>   (or `0`), all unused images are pruned.
    /// <br/>- `until=&lt;string&gt;` Prune images created before this timestamp. The `&lt;timestamp&gt;` can be Unix timestamps, date formatted timestamps, or Go duration strings (e.g. `10m`, `1h30m`) computed relative to the daemon machine’s time.
    /// <br/>- `label` (`label=&lt;key&gt;`, `label=&lt;key&gt;=&lt;value&gt;`, `label!=&lt;key&gt;`, or `label!=&lt;key&gt;=&lt;value&gt;`) Prune images with (or without, in case `label!=...` is used) the specified labels.</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<ImagePruneResponse> PruneAsync(string? filters = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "images/prune"
                urlBuilder.Append("images/prune");
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
                        var objectResponse = await ReadObjectResponseAsync<ImagePruneResponse>(response, headers, cancellationToken).ConfigureAwait(false);
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
    /// Create a new image from a container
    /// </summary>
    /// <param name="containerConfig">The container configuration</param>
    /// <param name="container">The ID or name of the container to commit</param>
    /// <param name="repo">Repository name for the created image</param>
    /// <param name="tag">Tag name for the create image</param>
    /// <param name="comment">Commit message</param>
    /// <param name="author">Author of the image (e.g., `John Hannibal Smith &lt;hannibal@a-team.com&gt;`)</param>
    /// <param name="pause">Whether to pause the container before committing</param>
    /// <param name="changes">`Dockerfile` instructions to apply while committing</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<IdResponse> CommitAsync(ContainerConfig? containerConfig = null, string? container = null, string? repo = null, string? tag = null, string? comment = null, string? author = null, bool? pause = null, string? changes = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                var json = System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(containerConfig, _settings.Value);
                var content = new ByteArrayContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "commit"
                urlBuilder.Append("commit");
                urlBuilder.Append('?');
                if (container != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("container")).Append('=').Append(Uri.EscapeDataString(ConvertToString(container, CultureInfo.InvariantCulture))).Append('&');
                }
                if (repo != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("repo")).Append('=').Append(Uri.EscapeDataString(ConvertToString(repo, CultureInfo.InvariantCulture))).Append('&');
                }
                if (tag != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("tag")).Append('=').Append(Uri.EscapeDataString(ConvertToString(tag, CultureInfo.InvariantCulture))).Append('&');
                }
                if (comment != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("comment")).Append('=').Append(Uri.EscapeDataString(ConvertToString(comment, CultureInfo.InvariantCulture))).Append('&');
                }
                if (author != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("author")).Append('=').Append(Uri.EscapeDataString(ConvertToString(author, CultureInfo.InvariantCulture))).Append('&');
                }
                if (pause != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("pause")).Append('=').Append(Uri.EscapeDataString(ConvertToString(pause, CultureInfo.InvariantCulture))).Append('&');
                }
                if (changes != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("changes")).Append('=').Append(Uri.EscapeDataString(ConvertToString(changes, CultureInfo.InvariantCulture))).Append('&');
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
    /// Export an image
    /// </summary>
    /// <remarks>
    /// Get a tarball containing all images and metadata for a repository.
    /// <br/>
    /// <br/>If `name` is a specific name and tag (e.g. `ubuntu:latest`), then only that image (and its parents) are returned. If `name` is an image ID, similarly only that image (and its parents) are returned, but with the exclusion of the `repositories` file in the tarball, as there were no image names referenced.
    /// <br/>
    /// <br/>### Image tarball format
    /// <br/>
    /// <br/>An image tarball contains one directory per image layer (named using its long ID), each containing these files:
    /// <br/>
    /// <br/>- `VERSION`: currently `1.0` - the file format version
    /// <br/>- `json`: detailed layer information, similar to `docker inspect layer_id`
    /// <br/>- `layer.tar`: A tarfile containing the filesystem changes in this layer
    /// <br/>
    /// <br/>The `layer.tar` file contains `aufs` style `.wh..wh.aufs` files and directories for storing attribute changes and deletions.
    /// <br/>
    /// <br/>If the tarball defines a repository, the tarball should also include a `repositories` file at the root that contains a list of repository and tag names mapped to layer IDs.
    /// <br/>
    /// <br/>```json
    /// <br/>{
    /// <br/>  "hello-world": {
    /// <br/>    "latest": "565a9d68a73f6706862bfe8409a7f659776d4d60a8d096eb4a3cbce6999cc2a1"
    /// <br/>  }
    /// <br/>}
    /// <br/>```
    /// </remarks>
    /// <param name="name">Image name or ID</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<FileResponse> GetAsync(string name, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(name);
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/x-tar"));

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "images/{name}/get"
                urlBuilder.Append("images/");
                urlBuilder.Append(Uri.EscapeDataString(ConvertToString(name, CultureInfo.InvariantCulture)));
                urlBuilder.Append("/get");

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
                        var responseStream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        var fileResponse = new FileResponse(statusCode, headers, responseStream, response);
                        disposeClient = false; disposeResponse = false; // response and client are disposed by FileResponse
                        return fileResponse;
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
    /// Export several images
    /// </summary>
    /// <remarks>
    /// Get a tarball containing all images and metadata for several image
    /// <br/>repositories.
    /// <br/>
    /// <br/>For each value of the `names` parameter: if it is a specific name and
    /// <br/>tag (e.g. `ubuntu:latest`), then only that image (and its parents) are
    /// <br/>returned; if it is an image ID, similarly only that image (and its parents)
    /// <br/>are returned and there would be no names referenced in the 'repositories'
    /// <br/>file for this image ID.
    /// <br/>
    /// <br/>For details on the format, see the [export image endpoint](#operation/ImageGet).
    /// </remarks>
    /// <param name="names">Image names to filter by</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task<FileResponse> GetAllAsync(IEnumerable<string>? names = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/x-tar"));

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "images/get"
                urlBuilder.Append("images/get");
                urlBuilder.Append('?');
                if (names != null)
                {
                    foreach (var item in names) { urlBuilder.Append(Uri.EscapeDataString("names")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item, CultureInfo.InvariantCulture))).Append('&'); }
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
                    if (statusCode == 200 || statusCode == 206)
                    {
                        var responseStream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        var fileResponse = new FileResponse(statusCode, headers, responseStream, response);
                        disposeClient = false; disposeResponse = false; // response and client are disposed by FileResponse
                        return fileResponse;
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
    /// Import images
    /// </summary>
    /// <remarks>
    /// Load a set of images and tags into a repository.
    /// <br/>
    /// <br/>For details on the format, see the [export image endpoint](#operation/ImageGet).
    /// </remarks>
    /// <param name="imagesTarball">Tar archive containing images</param>
    /// <param name="quiet">Suppress progress details during load.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    public virtual async Task LoadAsync(Stream imagesTarball = null, bool? quiet = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClient;
        var disposeClient = false;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                var content = new StreamContent(imagesTarball);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-tar");
                request.Content = content;
                request.Method = new HttpMethod("POST");

                var urlBuilder = new StringBuilder();
                
                // Operation Path: "images/load"
                urlBuilder.Append("images/load");
                urlBuilder.Append('?');
                if (quiet != null)
                {
                    urlBuilder.Append(Uri.EscapeDataString("quiet")).Append('=').Append(Uri.EscapeDataString(ConvertToString(quiet, CultureInfo.InvariantCulture))).Append('&');
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