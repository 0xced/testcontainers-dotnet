using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DockerEngine;
  
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial interface IDockerNetworkClient
{

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// List networks
    /// </summary>
    /// <remarks>
    /// Returns a list of networks. For details on the format, see the
    /// <br/>[network inspect endpoint](#operation/NetworkInspect).
    /// <br/>
    /// <br/>Note that it uses a different, smaller representation of a network than
    /// <br/>inspecting a single network. For example, the list of containers attached
    /// <br/>to the network is not propagated in API versions 1.28 and up.
    /// </remarks>
    /// <param name="filters">JSON encoded value of the filters (a `map[string][]string`) to process
    /// <br/>on the networks list.
    /// <br/>
    /// <br/>Available filters:
    /// <br/>
    /// <br/>- `dangling=&lt;boolean&gt;` When set to `true` (or `1`), returns all
    /// <br/>   networks that are not in use by a container. When set to `false`
    /// <br/>   (or `0`), only networks that are in use by one or more
    /// <br/>   containers are returned.
    /// <br/>- `driver=&lt;driver-name&gt;` Matches a network's driver.
    /// <br/>- `id=&lt;network-id&gt;` Matches all or part of a network ID.
    /// <br/>- `label=&lt;key&gt;` or `label=&lt;key&gt;=&lt;value&gt;` of a network label.
    /// <br/>- `name=&lt;network-name&gt;` Matches all or part of a network name.
    /// <br/>- `scope=["swarm"|"global"|"local"]` Filters networks by scope (`swarm`, `global`, or `local`).
    /// <br/>- `type=["custom"|"builtin"]` Filters networks by type. The `custom` keyword returns all user-defined networks.</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<ICollection<Network>> ListAsync(string? filters = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Inspect a network
    /// </summary>
    /// <param name="id">Network ID or name</param>
    /// <param name="verbose">Detailed inspect output for troubleshooting</param>
    /// <param name="scope">Filter the network by scope (swarm, global, or local)</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<Network> InspectAsync(string id, bool? verbose = null, string? scope = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Remove a network
    /// </summary>
    /// <param name="id">Network ID or name</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task DeleteAsync(string id, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Create a network
    /// </summary>
    /// <param name="networkConfig">Network configuration</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<NetworkCreateResponse> CreateAsync(NetworkCreateRequest networkConfig, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Connect a container to a network
    /// </summary>
    /// <remarks>
    /// The network must be either a local-scoped network or a swarm-scoped network with the `attachable` option set. A network cannot be re-attached to a running container
    /// </remarks>
    /// <param name="id">Network ID or name</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task ConnectAsync(string id, NetworkConnectRequest container, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Disconnect a container from a network
    /// </summary>
    /// <param name="id">Network ID or name</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task DisconnectAsync(string id, NetworkDisconnectRequest container, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Delete unused networks
    /// </summary>
    /// <param name="filters">Filters to process on the prune list, encoded as JSON (a `map[string][]string`).
    /// <br/>
    /// <br/>Available filters:
    /// <br/>- `until=&lt;timestamp&gt;` Prune networks created before this timestamp. The `&lt;timestamp&gt;` can be Unix timestamps, date formatted timestamps, or Go duration strings (e.g. `10m`, `1h30m`) computed relative to the daemon machine’s time.
    /// <br/>- `label` (`label=&lt;key&gt;`, `label=&lt;key&gt;=&lt;value&gt;`, `label!=&lt;key&gt;`, or `label!=&lt;key&gt;=&lt;value&gt;`) Prune networks with (or without, in case `label!=...` is used) the specified labels.</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<NetworkPruneResponse> PruneAsync(string? filters = null, CancellationToken cancellationToken = default);

}