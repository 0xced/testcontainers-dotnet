using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DockerEngine;
  
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial interface IDockerSwarmClient
{

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Inspect swarm
    /// </summary>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<Swarm> InspectAsync(CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Initialize a new swarm
    /// </summary>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<string> InitAsync(SwarmInitRequest body, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Join an existing swarm
    /// </summary>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task JoinAsync(SwarmJoinRequest body, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Leave a swarm
    /// </summary>
    /// <param name="force">Force leave swarm, even if this is the last manager or that it will
    /// <br/>break the cluster.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task LeaveAsync(bool? force = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Update a swarm
    /// </summary>
    /// <param name="version">The version number of the swarm object being updated. This is
    /// <br/>required to avoid conflicting writes.</param>
    /// <param name="rotateWorkerToken">Rotate the worker join token.</param>
    /// <param name="rotateManagerToken">Rotate the manager join token.</param>
    /// <param name="rotateManagerUnlockKey">Rotate the manager unlock key.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task UpdateAsync(SwarmSpec body, long version, bool? rotateWorkerToken = null, bool? rotateManagerToken = null, bool? rotateManagerUnlockKey = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get the unlock key
    /// </summary>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<UnlockKeyResponse> UnlockkeyAsync(CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Unlock a locked manager
    /// </summary>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task UnlockAsync(SwarmUnlockRequest body, CancellationToken cancellationToken = default);

}