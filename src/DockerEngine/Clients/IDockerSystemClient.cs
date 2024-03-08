using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DockerEngine;
  
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial interface IDockerSystemClient
{

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
    Task<Response> AuthAsync(AuthConfig? authConfig = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get system information
    /// </summary>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<SystemInfo> InfoAsync(CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get version
    /// </summary>
    /// <remarks>
    /// Returns the version of Docker that is running and various information about the system that Docker is running on.
    /// </remarks>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<SystemVersion> VersionAsync(CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Ping
    /// </summary>
    /// <remarks>
    /// This is a dummy endpoint you can use to test if the server is accessible.
    /// </remarks>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<string> PingAsync(CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Ping
    /// </summary>
    /// <remarks>
    /// This is a dummy endpoint you can use to test if the server is accessible.
    /// </remarks>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<string> PingHeadAsync(CancellationToken cancellationToken = default);


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
    Task<EventMessage> EventsAsync(string? since = null, string? until = null, string? filters = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get data usage information
    /// </summary>
    /// <param name="type">Object types, for which to compute and return data.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<SystemDataUsageResponse> DataUsageAsync(IEnumerable<Anonymous>? type = null, CancellationToken cancellationToken = default);

}