using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DockerEngine;
  
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial interface IDockerNodeClient
{

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// List nodes
    /// </summary>
    /// <param name="filters">Filters to process on the nodes list, encoded as JSON (a `map[string][]string`).
    /// <br/>
    /// <br/>Available filters:
    /// <br/>- `id=&lt;node id&gt;`
    /// <br/>- `label=&lt;engine label&gt;`
    /// <br/>- `membership=`(`accepted`|`pending`)`
    /// <br/>- `name=&lt;node name&gt;`
    /// <br/>- `node.label=&lt;node label&gt;`
    /// <br/>- `role=`(`manager`|`worker`)`</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<ICollection<Node>> ListAsync(string? filters = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Inspect a node
    /// </summary>
    /// <param name="id">The ID or name of the node</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<Node> InspectAsync(string id, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Delete a node
    /// </summary>
    /// <param name="id">The ID or name of the node</param>
    /// <param name="force">Force remove a node from the swarm</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task DeleteAsync(string id, bool? force = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Update a node
    /// </summary>
    /// <param name="id">The ID of the node</param>
    /// <param name="version">The version number of the node object being updated. This is required
    /// <br/>to avoid conflicting writes.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task UpdateAsync(string id, long version, NodeSpec? body = null, CancellationToken cancellationToken = default);

}