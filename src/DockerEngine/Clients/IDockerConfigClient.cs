using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DockerEngine;
  
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial interface IDockerConfigClient
{

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// List configs
    /// </summary>
    /// <param name="filters">A JSON encoded value of the filters (a `map[string][]string`) to
    /// <br/>process on the configs list.
    /// <br/>
    /// <br/>Available filters:
    /// <br/>
    /// <br/>- `id=&lt;config id&gt;`
    /// <br/>- `label=&lt;key&gt; or label=&lt;key&gt;=value`
    /// <br/>- `name=&lt;config name&gt;`
    /// <br/>- `names=&lt;config name&gt;`</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<ICollection<Config>> ListAsync(string? filters = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Create a config
    /// </summary>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<IdResponse> CreateAsync(Body6? body = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Inspect a config
    /// </summary>
    /// <param name="id">ID of the config</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<Config> InspectAsync(string id, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Delete a config
    /// </summary>
    /// <param name="id">ID of the config</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task DeleteAsync(string id, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Update a Config
    /// </summary>
    /// <param name="id">The ID or name of the config</param>
    /// <param name="version">The version number of the config object being updated. This is
    /// <br/>required to avoid conflicting writes.</param>
    /// <param name="body">The spec of the config to update. Currently, only the Labels field
    /// <br/>can be updated. All other fields must remain unchanged from the
    /// <br/>[ConfigInspect endpoint](#operation/ConfigInspect) response values.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task UpdateAsync(string id, long version, ConfigSpec? body = null, CancellationToken cancellationToken = default);

}