using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DockerEngine;
  
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial interface IDockerExecClient
{

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Create an exec instance
    /// </summary>
    /// <remarks>
    /// Run a command inside a running container.
    /// </remarks>
    /// <param name="execConfig">Exec configuration</param>
    /// <param name="id">ID or name of container</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<IdResponse> ContainerExecAsync(ExecConfig execConfig, string id, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Start an exec instance
    /// </summary>
    /// <remarks>
    /// Starts a previously set up exec instance. If detach is true, this endpoint
    /// <br/>returns immediately after starting the command. Otherwise, it sets up an
    /// <br/>interactive session with the command.
    /// </remarks>
    /// <param name="id">Exec instance ID</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<FileResponse> StartAsync(string id, ExecStartConfig? execStartConfig = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Resize an exec instance
    /// </summary>
    /// <remarks>
    /// Resize the TTY session used by an exec instance. This endpoint only works
    /// <br/>if `tty` was specified as part of creating and starting the exec instance.
    /// </remarks>
    /// <param name="id">Exec instance ID</param>
    /// <param name="h">Height of the TTY session in characters</param>
    /// <param name="w">Width of the TTY session in characters</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task ResizeAsync(string id, int? h = null, int? w = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Inspect an exec instance
    /// </summary>
    /// <remarks>
    /// Return low-level information about an exec instance.
    /// </remarks>
    /// <param name="id">Exec instance ID</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<ExecInspectResponse> InspectAsync(string id, CancellationToken cancellationToken = default);

}