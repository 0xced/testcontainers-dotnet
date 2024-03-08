using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DockerEngine;
  
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial interface IDockerServiceClient
{

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// List services
    /// </summary>
    /// <param name="filters">A JSON encoded value of the filters (a `map[string][]string`) to
    /// <br/>process on the services list.
    /// <br/>
    /// <br/>Available filters:
    /// <br/>
    /// <br/>- `id=&lt;service id&gt;`
    /// <br/>- `label=&lt;service label&gt;`
    /// <br/>- `mode=["replicated"|"global"]`
    /// <br/>- `name=&lt;service name&gt;`</param>
    /// <param name="status">Include service status, with count of running and desired tasks.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<IReadOnlyCollection<Service>> ListAsync(string? filters = null, bool? status = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Create a service
    /// </summary>
    /// <param name="x_Registry_Auth">A base64url-encoded auth configuration for pulling from private
    /// <br/>registries.
    /// <br/>
    /// <br/>Refer to the [authentication section](#section/Authentication) for
    /// <br/>details.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<ServiceCreateResponse> CreateAsync(Body3 body, string? x_Registry_Auth = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Inspect a service
    /// </summary>
    /// <param name="id">ID or name of service.</param>
    /// <param name="insertDefaults">Fill empty fields with default values.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<Service> InspectAsync(string id, bool? insertDefaults = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Delete a service
    /// </summary>
    /// <param name="id">ID or name of service.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task DeleteAsync(string id, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Update a service
    /// </summary>
    /// <param name="id">ID or name of service.</param>
    /// <param name="version">The version number of the service object being updated. This is
    /// <br/>required to avoid conflicting writes.
    /// <br/>This version number should be the value as currently set on the
    /// <br/>service *before* the update. You can find the current version by
    /// <br/>calling `GET /services/{id}`</param>
    /// <param name="registryAuthFrom">If the `X-Registry-Auth` header is not specified, this parameter
    /// <br/>indicates where to find registry authorization credentials.</param>
    /// <param name="rollback">Set to this parameter to `previous` to cause a server-side rollback
    /// <br/>to the previous service spec. The supplied spec will be ignored in
    /// <br/>this case.</param>
    /// <param name="x_Registry_Auth">A base64url-encoded auth configuration for pulling from private
    /// <br/>registries.
    /// <br/>
    /// <br/>Refer to the [authentication section](#section/Authentication) for
    /// <br/>details.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<ServiceUpdateResponse> UpdateAsync(string id, Body4 body, int version, RegistryAuthFrom? registryAuthFrom = null, string? rollback = null, string? x_Registry_Auth = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get service logs
    /// </summary>
    /// <remarks>
    /// Get `stdout` and `stderr` logs from a service. See also
    /// <br/>[`/containers/{id}/logs`](#operation/ContainerLogs).
    /// <br/>
    /// <br/>**Note**: This endpoint works only for services with the `local`,
    /// <br/>`json-file` or `journald` logging drivers.
    /// </remarks>
    /// <param name="id">ID or name of the service</param>
    /// <param name="details">Show service context and extra details provided to logs.</param>
    /// <param name="follow">Keep connection after returning logs.</param>
    /// <param name="stdout">Return logs from `stdout`</param>
    /// <param name="stderr">Return logs from `stderr`</param>
    /// <param name="since">Only return logs since this time, as a UNIX timestamp</param>
    /// <param name="timestamps">Add timestamps to every log line</param>
    /// <param name="tail">Only return this number of log lines from the end of the logs.
    /// <br/>Specify as an integer or `all` to output all log lines.</param>
    /// <returns>logs returned as a stream in response body</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<FileResponse> LogsAsync(string id, bool? details = null, bool? follow = null, bool? stdout = null, bool? stderr = null, int? since = null, bool? timestamps = null, string? tail = null, CancellationToken cancellationToken = default);

}