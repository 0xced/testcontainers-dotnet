using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DockerEngine;
  
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial interface IDockerSecretClient
{

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
    Task<IReadOnlyCollection<Secret>> ListAsync(string? filters = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Create a secret
    /// </summary>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<IdResponse> CreateAsync(Body5? body = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Inspect a secret
    /// </summary>
    /// <param name="id">ID of the secret</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<Secret> InspectAsync(string id, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Delete a secret
    /// </summary>
    /// <param name="id">ID of the secret</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task DeleteAsync(string id, CancellationToken cancellationToken = default);


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
    Task UpdateAsync(string id, long version, SecretSpec? body = null, CancellationToken cancellationToken = default);

}