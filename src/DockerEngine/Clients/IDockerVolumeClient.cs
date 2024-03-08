using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DockerEngine;
  
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial interface IDockerVolumeClient
{

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// List volumes
    /// </summary>
    /// <param name="filters">JSON encoded value of the filters (a `map[string][]string`) to
    /// <br/>process on the volumes list. Available filters:
    /// <br/>
    /// <br/>- `dangling=&lt;boolean&gt;` When set to `true` (or `1`), returns all
    /// <br/>   volumes that are not in use by a container. When set to `false`
    /// <br/>   (or `0`), only volumes that are in use by one or more
    /// <br/>   containers are returned.
    /// <br/>- `driver=&lt;volume-driver-name&gt;` Matches volumes based on their driver.
    /// <br/>- `label=&lt;key&gt;` or `label=&lt;key&gt;:&lt;value&gt;` Matches volumes based on
    /// <br/>   the presence of a `label` alone or a `label` and a value.
    /// <br/>- `name=&lt;volume-name&gt;` Matches all or part of a volume name.</param>
    /// <returns>Summary volume data that matches the query</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<VolumeListResponse> ListAsync(string? filters = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Create a volume
    /// </summary>
    /// <param name="volumeConfig">Volume configuration</param>
    /// <returns>The volume was created successfully</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<Volume> CreateAsync(VolumeCreateOptions volumeConfig, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Inspect a volume
    /// </summary>
    /// <param name="name">Volume name or ID</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<Volume> InspectAsync(string name, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// "Update a volume. Valid only for Swarm cluster volumes"
    /// </summary>
    /// <param name="name">The name or ID of the volume</param>
    /// <param name="version">The version number of the volume being updated. This is required to
    /// <br/>avoid conflicting writes. Found in the volume's `ClusterVolume`
    /// <br/>field.</param>
    /// <param name="body">The spec of the volume to update. Currently, only Availability may
    /// <br/>change. All other fields must remain unchanged.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task UpdateAsync(string name, long version, Body2? body = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Remove a volume
    /// </summary>
    /// <remarks>
    /// Instruct the driver to remove the volume.
    /// </remarks>
    /// <param name="name">Volume name or ID</param>
    /// <param name="force">Force the removal of the volume</param>
    /// <returns>The volume was removed</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task DeleteAsync(string name, bool? force = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Delete unused volumes
    /// </summary>
    /// <param name="filters">Filters to process on the prune list, encoded as JSON (a `map[string][]string`).
    /// <br/>
    /// <br/>Available filters:
    /// <br/>- `label` (`label=&lt;key&gt;`, `label=&lt;key&gt;=&lt;value&gt;`, `label!=&lt;key&gt;`, or `label!=&lt;key&gt;=&lt;value&gt;`) Prune volumes with (or without, in case `label!=...` is used) the specified labels.
    /// <br/>- `all` (`all=true`) - Consider all (local) volumes for pruning and not just anonymous volumes.</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<VolumePruneResponse> PruneAsync(string? filters = null, CancellationToken cancellationToken = default);

}