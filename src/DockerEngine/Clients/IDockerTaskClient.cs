using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DockerEngine;
  
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial interface IDockerTaskClient
{

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// List tasks
    /// </summary>
    /// <param name="filters">A JSON encoded value of the filters (a `map[string][]string`) to
    /// <br/>process on the tasks list.
    /// <br/>
    /// <br/>Available filters:
    /// <br/>
    /// <br/>- `desired-state=(running | shutdown | accepted)`
    /// <br/>- `id=&lt;task id&gt;`
    /// <br/>- `label=key` or `label="key=value"`
    /// <br/>- `name=&lt;task name&gt;`
    /// <br/>- `node=&lt;node id or name&gt;`
    /// <br/>- `service=&lt;service name&gt;`</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<ICollection<DockerTask>> ListAsync(string? filters = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Inspect a task
    /// </summary>
    /// <param name="id">ID of the task</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<DockerTask> InspectAsync(string id, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get task logs
    /// </summary>
    /// <remarks>
    /// Get `stdout` and `stderr` logs from a task.
    /// <br/>See also [`/containers/{id}/logs`](#operation/ContainerLogs).
    /// <br/>
    /// <br/>**Note**: This endpoint works only for services with the `local`,
    /// <br/>`json-file` or `journald` logging drivers.
    /// </remarks>
    /// <param name="id">ID of the task</param>
    /// <param name="details">Show task context and extra details provided to logs.</param>
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