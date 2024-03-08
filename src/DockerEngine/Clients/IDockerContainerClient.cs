using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DockerEngine;
  
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial interface IDockerContainerClient
{

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// List containers
    /// </summary>
    /// <remarks>
    /// Returns a list of containers. For details on the format, see the
    /// <br/>[inspect endpoint](#operation/ContainerInspect).
    /// <br/>
    /// <br/>Note that it uses a different, smaller representation of a container
    /// <br/>than inspecting a single container. For example, the list of linked
    /// <br/>containers is not propagated .
    /// </remarks>
    /// <param name="all">Return all containers. By default, only running containers are shown.</param>
    /// <param name="limit">Return this number of most recently created containers, including
    /// <br/>non-running ones.</param>
    /// <param name="size">Return the size of container as fields `SizeRw` and `SizeRootFs`.</param>
    /// <param name="filters">Filters to process on the container list, encoded as JSON (a
    /// <br/>`map[string][]string`). For example, `{"status": ["paused"]}` will
    /// <br/>only return paused containers.
    /// <br/>
    /// <br/>Available filters:
    /// <br/>
    /// <br/>- `ancestor`=(`&lt;image-name&gt;[:&lt;tag&gt;]`, `&lt;image id&gt;`, or `&lt;image@digest&gt;`)
    /// <br/>- `before`=(`&lt;container id&gt;` or `&lt;container name&gt;`)
    /// <br/>- `expose`=(`&lt;port&gt;[/&lt;proto&gt;]`|`&lt;startport-endport&gt;/[&lt;proto&gt;]`)
    /// <br/>- `exited=&lt;int&gt;` containers with exit code of `&lt;int&gt;`
    /// <br/>- `health`=(`starting`|`healthy`|`unhealthy`|`none`)
    /// <br/>- `id=&lt;ID&gt;` a container's ID
    /// <br/>- `isolation=`(`default`|`process`|`hyperv`) (Windows daemon only)
    /// <br/>- `is-task=`(`true`|`false`)
    /// <br/>- `label=key` or `label="key=value"` of a container label
    /// <br/>- `name=&lt;name&gt;` a container's name
    /// <br/>- `network`=(`&lt;network id&gt;` or `&lt;network name&gt;`)
    /// <br/>- `publish`=(`&lt;port&gt;[/&lt;proto&gt;]`|`&lt;startport-endport&gt;/[&lt;proto&gt;]`)
    /// <br/>- `since`=(`&lt;container id&gt;` or `&lt;container name&gt;`)
    /// <br/>- `status=`(`created`|`restarting`|`running`|`removing`|`paused`|`exited`|`dead`)
    /// <br/>- `volume`=(`&lt;volume name&gt;` or `&lt;mount point destination&gt;`)</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<IReadOnlyCollection<ContainerSummary>> ListAsync(bool? all = null, int? limit = null, bool? size = null, string? filters = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Create a container
    /// </summary>
    /// <param name="body">Container to create</param>
    /// <param name="name">Assign the specified name to the container. Must match
    /// <br/>`/?[a-zA-Z0-9][a-zA-Z0-9_.-]+`.</param>
    /// <param name="platform">Platform in the format `os[/arch[/variant]]` used for image lookup.
    /// <br/>
    /// <br/>When specified, the daemon checks if the requested image is present
    /// <br/>in the local image cache with the given OS and Architecture, and
    /// <br/>otherwise returns a `404` status.
    /// <br/>
    /// <br/>If the option is not set, the host's native OS and Architecture are
    /// <br/>used to look up the image in the image cache. However, if no platform
    /// <br/>is passed and the given image does exist in the local image cache,
    /// <br/>but its OS or architecture does not match, the container is created
    /// <br/>with the available image, and a warning is added to the `Warnings`
    /// <br/>field in the response, for example;
    /// <br/>
    /// <br/>    WARNING: The requested image's platform (linux/arm64/v8) does not
    /// <br/>             match the detected host platform (linux/amd64) and no
    /// <br/>             specific platform was requested</param>
    /// <returns>Container created successfully</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<ContainerCreateResponse> CreateAsync(Body body, string? name = null, string? platform = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Inspect a container
    /// </summary>
    /// <remarks>
    /// Return low-level information about a container.
    /// </remarks>
    /// <param name="id">ID or name of the container</param>
    /// <param name="size">Return the size of container as fields `SizeRw` and `SizeRootFs`</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<ContainerInspectResponse> InspectAsync(string id, bool? size = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// List processes running inside a container
    /// </summary>
    /// <remarks>
    /// On Unix systems, this is done by running the `ps` command. This endpoint
    /// <br/>is not supported on Windows.
    /// </remarks>
    /// <param name="id">ID or name of the container</param>
    /// <param name="ps_args">The arguments to pass to `ps`. For example, `aux`</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<ContainerTopResponse> TopAsync(string id, string? ps_args = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get container logs
    /// </summary>
    /// <remarks>
    /// Get `stdout` and `stderr` logs from a container.
    /// <br/>
    /// <br/>Note: This endpoint works only for containers with the `json-file` or
    /// <br/>`journald` logging driver.
    /// </remarks>
    /// <param name="id">ID or name of the container</param>
    /// <param name="follow">Keep connection after returning logs.</param>
    /// <param name="stdout">Return logs from `stdout`</param>
    /// <param name="stderr">Return logs from `stderr`</param>
    /// <param name="since">Only return logs since this time, as a UNIX timestamp</param>
    /// <param name="until">Only return logs before this time, as a UNIX timestamp</param>
    /// <param name="timestamps">Add timestamps to every log line</param>
    /// <param name="tail">Only return this number of log lines from the end of the logs.
    /// <br/>Specify as an integer or `all` to output all log lines.</param>
    /// <returns>logs returned as a stream in response body.
    /// <br/>For the stream format, [see the documentation for the attach endpoint](#operation/ContainerAttach).
    /// <br/>Note that unlike the attach endpoint, the logs endpoint does not
    /// <br/>upgrade the connection and does not set Content-Type.</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<FileResponse> LogsAsync(string id, bool? follow = null, bool? stdout = null, bool? stderr = null, int? since = null, int? until = null, bool? timestamps = null, string? tail = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get changes on a container’s filesystem
    /// </summary>
    /// <remarks>
    /// Returns which files in a container's filesystem have been added, deleted,
    /// <br/>or modified. The `Kind` of modification can be one of:
    /// <br/>
    /// <br/>- `0`: Modified ("C")
    /// <br/>- `1`: Added ("A")
    /// <br/>- `2`: Deleted ("D")
    /// </remarks>
    /// <param name="id">ID or name of the container</param>
    /// <returns>The list of changes</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<IReadOnlyCollection<FilesystemChange>> ChangesAsync(string id, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Export a container
    /// </summary>
    /// <remarks>
    /// Export the contents of a container as a tarball.
    /// </remarks>
    /// <param name="id">ID or name of the container</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<FileResponse> ExportAsync(string id, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get container stats based on resource usage
    /// </summary>
    /// <remarks>
    /// This endpoint returns a live stream of a container’s resource usage
    /// <br/>statistics.
    /// <br/>
    /// <br/>The `precpu_stats` is the CPU statistic of the *previous* read, and is
    /// <br/>used to calculate the CPU usage percentage. It is not an exact copy
    /// <br/>of the `cpu_stats` field.
    /// <br/>
    /// <br/>If either `precpu_stats.online_cpus` or `cpu_stats.online_cpus` is
    /// <br/>nil then for compatibility with older daemons the length of the
    /// <br/>corresponding `cpu_usage.percpu_usage` array should be used.
    /// <br/>
    /// <br/>On a cgroup v2 host, the following fields are not set
    /// <br/>* `blkio_stats`: all fields other than `io_service_bytes_recursive`
    /// <br/>* `cpu_stats`: `cpu_usage.percpu_usage`
    /// <br/>* `memory_stats`: `max_usage` and `failcnt`
    /// <br/>Also, `memory_stats.stats` fields are incompatible with cgroup v1.
    /// <br/>
    /// <br/>To calculate the values shown by the `stats` command of the docker cli tool
    /// <br/>the following formulas can be used:
    /// <br/>* used_memory = `memory_stats.usage - memory_stats.stats.cache`
    /// <br/>* available_memory = `memory_stats.limit`
    /// <br/>* Memory usage % = `(used_memory / available_memory) * 100.0`
    /// <br/>* cpu_delta = `cpu_stats.cpu_usage.total_usage - precpu_stats.cpu_usage.total_usage`
    /// <br/>* system_cpu_delta = `cpu_stats.system_cpu_usage - precpu_stats.system_cpu_usage`
    /// <br/>* number_cpus = `lenght(cpu_stats.cpu_usage.percpu_usage)` or `cpu_stats.online_cpus`
    /// <br/>* CPU usage % = `(cpu_delta / system_cpu_delta) * number_cpus * 100.0`
    /// </remarks>
    /// <param name="id">ID or name of the container</param>
    /// <param name="stream">Stream the output. If false, the stats will be output once and then
    /// <br/>it will disconnect.</param>
    /// <param name="one_shot">Only get a single stat instead of waiting for 2 cycles. Must be used
    /// <br/>with `stream=false`.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<object> StatsAsync(string id, bool? stream = null, bool? one_shot = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Resize a container TTY
    /// </summary>
    /// <remarks>
    /// Resize the TTY for a container.
    /// </remarks>
    /// <param name="id">ID or name of the container</param>
    /// <param name="h">Height of the TTY session in characters</param>
    /// <param name="w">Width of the TTY session in characters</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task ResizeAsync(string id, int? h = null, int? w = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Start a container
    /// </summary>
    /// <param name="id">ID or name of the container</param>
    /// <param name="detachKeys">Override the key sequence for detaching a container. Format is a
    /// <br/>single character `[a-Z]` or `ctrl-&lt;value&gt;` where `&lt;value&gt;` is one
    /// <br/>of: `a-z`, `@`, `^`, `[`, `,` or `_`.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task StartAsync(string id, string? detachKeys = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Stop a container
    /// </summary>
    /// <param name="id">ID or name of the container</param>
    /// <param name="signal">Signal to send to the container as an integer or string (e.g. `SIGINT`).</param>
    /// <param name="t">Number of seconds to wait before killing the container</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task StopAsync(string id, string? signal = null, int? t = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Restart a container
    /// </summary>
    /// <param name="id">ID or name of the container</param>
    /// <param name="signal">Signal to send to the container as an integer or string (e.g. `SIGINT`).</param>
    /// <param name="t">Number of seconds to wait before killing the container</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task RestartAsync(string id, string? signal = null, int? t = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Kill a container
    /// </summary>
    /// <remarks>
    /// Send a POSIX signal to a container, defaulting to killing to the
    /// <br/>container.
    /// </remarks>
    /// <param name="id">ID or name of the container</param>
    /// <param name="signal">Signal to send to the container as an integer or string (e.g. `SIGINT`).</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task KillAsync(string id, string? signal = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Update a container
    /// </summary>
    /// <remarks>
    /// Change various configuration options of a container without having to
    /// <br/>recreate it.
    /// </remarks>
    /// <param name="id">ID or name of the container</param>
    /// <returns>The container has been updated.</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<ContainerUpdateResponse> UpdateAsync(string id, Update update, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Rename a container
    /// </summary>
    /// <param name="id">ID or name of the container</param>
    /// <param name="name">New name for the container</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task RenameAsync(string id, string name, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Pause a container
    /// </summary>
    /// <remarks>
    /// Use the freezer cgroup to suspend all processes in a container.
    /// <br/>
    /// <br/>Traditionally, when suspending a process the `SIGSTOP` signal is used,
    /// <br/>which is observable by the process being suspended. With the freezer
    /// <br/>cgroup the process is unaware, and unable to capture, that it is being
    /// <br/>suspended, and subsequently resumed.
    /// </remarks>
    /// <param name="id">ID or name of the container</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task PauseAsync(string id, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Unpause a container
    /// </summary>
    /// <remarks>
    /// Resume a container which has been paused.
    /// </remarks>
    /// <param name="id">ID or name of the container</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task UnpauseAsync(string id, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Attach to a container
    /// </summary>
    /// <remarks>
    /// Attach to a container to read its output or send it input. You can attach
    /// <br/>to the same container multiple times and you can reattach to containers
    /// <br/>that have been detached.
    /// <br/>
    /// <br/>Either the `stream` or `logs` parameter must be `true` for this endpoint
    /// <br/>to do anything.
    /// <br/>
    /// <br/>See the [documentation for the `docker attach` command](https://docs.docker.com/engine/reference/commandline/attach/)
    /// <br/>for more details.
    /// <br/>
    /// <br/>### Hijacking
    /// <br/>
    /// <br/>This endpoint hijacks the HTTP connection to transport `stdin`, `stdout`,
    /// <br/>and `stderr` on the same socket.
    /// <br/>
    /// <br/>This is the response from the daemon for an attach request:
    /// <br/>
    /// <br/>```
    /// <br/>HTTP/1.1 200 OK
    /// <br/>Content-Type: application/vnd.docker.raw-stream
    /// <br/>
    /// <br/>[STREAM]
    /// <br/>```
    /// <br/>
    /// <br/>After the headers and two new lines, the TCP connection can now be used
    /// <br/>for raw, bidirectional communication between the client and server.
    /// <br/>
    /// <br/>To hint potential proxies about connection hijacking, the Docker client
    /// <br/>can also optionally send connection upgrade headers.
    /// <br/>
    /// <br/>For example, the client sends this request to upgrade the connection:
    /// <br/>
    /// <br/>```
    /// <br/>POST /containers/16253994b7c4/attach?stream=1&amp;stdout=1 HTTP/1.1
    /// <br/>Upgrade: tcp
    /// <br/>Connection: Upgrade
    /// <br/>```
    /// <br/>
    /// <br/>The Docker daemon will respond with a `101 UPGRADED` response, and will
    /// <br/>similarly follow with the raw stream:
    /// <br/>
    /// <br/>```
    /// <br/>HTTP/1.1 101 UPGRADED
    /// <br/>Content-Type: application/vnd.docker.raw-stream
    /// <br/>Connection: Upgrade
    /// <br/>Upgrade: tcp
    /// <br/>
    /// <br/>[STREAM]
    /// <br/>```
    /// <br/>
    /// <br/>### Stream format
    /// <br/>
    /// <br/>When the TTY setting is disabled in [`POST /containers/create`](#operation/ContainerCreate),
    /// <br/>the HTTP Content-Type header is set to application/vnd.docker.multiplexed-stream
    /// <br/>and the stream over the hijacked connected is multiplexed to separate out
    /// <br/>`stdout` and `stderr`. The stream consists of a series of frames, each
    /// <br/>containing a header and a payload.
    /// <br/>
    /// <br/>The header contains the information which the stream writes (`stdout` or
    /// <br/>`stderr`). It also contains the size of the associated frame encoded in
    /// <br/>the last four bytes (`uint32`).
    /// <br/>
    /// <br/>It is encoded on the first eight bytes like this:
    /// <br/>
    /// <br/>```go
    /// <br/>header := [8]byte{STREAM_TYPE, 0, 0, 0, SIZE1, SIZE2, SIZE3, SIZE4}
    /// <br/>```
    /// <br/>
    /// <br/>`STREAM_TYPE` can be:
    /// <br/>
    /// <br/>- 0: `stdin` (is written on `stdout`)
    /// <br/>- 1: `stdout`
    /// <br/>- 2: `stderr`
    /// <br/>
    /// <br/>`SIZE1, SIZE2, SIZE3, SIZE4` are the four bytes of the `uint32` size
    /// <br/>encoded as big endian.
    /// <br/>
    /// <br/>Following the header is the payload, which is the specified number of
    /// <br/>bytes of `STREAM_TYPE`.
    /// <br/>
    /// <br/>The simplest way to implement this protocol is the following:
    /// <br/>
    /// <br/>1. Read 8 bytes.
    /// <br/>2. Choose `stdout` or `stderr` depending on the first byte.
    /// <br/>3. Extract the frame size from the last four bytes.
    /// <br/>4. Read the extracted size and output it on the correct output.
    /// <br/>5. Goto 1.
    /// <br/>
    /// <br/>### Stream format when using a TTY
    /// <br/>
    /// <br/>When the TTY setting is enabled in [`POST /containers/create`](#operation/ContainerCreate),
    /// <br/>the stream is not multiplexed. The data exchanged over the hijacked
    /// <br/>connection is simply the raw data from the process PTY and client's
    /// <br/>`stdin`.
    /// </remarks>
    /// <param name="id">ID or name of the container</param>
    /// <param name="detachKeys">Override the key sequence for detaching a container.Format is a single
    /// <br/>character `[a-Z]` or `ctrl-&lt;value&gt;` where `&lt;value&gt;` is one of: `a-z`,
    /// <br/>`@`, `^`, `[`, `,` or `_`.</param>
    /// <param name="logs">Replay previous logs from the container.
    /// <br/>
    /// <br/>This is useful for attaching to a container that has started and you
    /// <br/>want to output everything since the container started.
    /// <br/>
    /// <br/>If `stream` is also enabled, once all the previous output has been
    /// <br/>returned, it will seamlessly transition into streaming current
    /// <br/>output.</param>
    /// <param name="stream">Stream attached streams from the time the request was made onwards.</param>
    /// <param name="stdin">Attach to `stdin`</param>
    /// <param name="stdout">Attach to `stdout`</param>
    /// <param name="stderr">Attach to `stderr`</param>
    /// <returns>no error, no upgrade header found</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<FileResponse> AttachAsync(string id, string? detachKeys = null, bool? logs = null, bool? stream = null, bool? stdin = null, bool? stdout = null, bool? stderr = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Attach to a container via a websocket
    /// </summary>
    /// <param name="id">ID or name of the container</param>
    /// <param name="detachKeys">Override the key sequence for detaching a container.Format is a single
    /// <br/>character `[a-Z]` or `ctrl-&lt;value&gt;` where `&lt;value&gt;` is one of: `a-z`,
    /// <br/>`@`, `^`, `[`, `,`, or `_`.</param>
    /// <param name="logs">Return logs</param>
    /// <param name="stream">Return stream</param>
    /// <param name="stdin">Attach to `stdin`</param>
    /// <param name="stdout">Attach to `stdout`</param>
    /// <param name="stderr">Attach to `stderr`</param>
    /// <returns>no error, no upgrade header found</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task AttachWebsocketAsync(string id, string? detachKeys = null, bool? logs = null, bool? stream = null, bool? stdin = null, bool? stdout = null, bool? stderr = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Wait for a container
    /// </summary>
    /// <remarks>
    /// Block until a container stops, then returns the exit code.
    /// </remarks>
    /// <param name="id">ID or name of the container</param>
    /// <param name="condition">Wait until a container state reaches the given condition.
    /// <br/>
    /// <br/>Defaults to `not-running` if omitted or empty.</param>
    /// <returns>The container has exit.</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<ContainerWaitResponse> WaitAsync(string id, Condition? condition = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Remove a container
    /// </summary>
    /// <param name="id">ID or name of the container</param>
    /// <param name="v">Remove anonymous volumes associated with the container.</param>
    /// <param name="force">If the container is running, kill it before removing it.</param>
    /// <param name="link">Remove the specified link associated with the container.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task DeleteAsync(string id, bool? v = null, bool? force = null, bool? link = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get information about files in a container
    /// </summary>
    /// <remarks>
    /// A response header `X-Docker-Container-Path-Stat` is returned, containing
    /// <br/>a base64 - encoded JSON object with some filesystem header information
    /// <br/>about the path.
    /// </remarks>
    /// <param name="id">ID or name of the container</param>
    /// <param name="path">Resource in the container’s filesystem to archive.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task ArchiveInfoAsync(string id, string path, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get an archive of a filesystem resource in a container
    /// </summary>
    /// <remarks>
    /// Get a tar archive of a resource in the filesystem of container id.
    /// </remarks>
    /// <param name="id">ID or name of the container</param>
    /// <param name="path">Resource in the container’s filesystem to archive.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<FileResponse> ArchiveAsync(string id, string path, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Extract an archive of files or folders to a directory in a container
    /// </summary>
    /// <remarks>
    /// Upload a tar archive to be extracted to a path in the filesystem of container id.
    /// <br/>`path` parameter is asserted to be a directory. If it exists as a file, 400 error
    /// <br/>will be returned with message "not a directory".
    /// </remarks>
    /// <param name="id">ID or name of the container</param>
    /// <param name="path">Path to a directory in the container to extract the archive’s contents into.</param>
    /// <param name="inputStream">The input stream must be a tar archive compressed with one of the
    /// <br/>following algorithms: `identity` (no compression), `gzip`, `bzip2`,
    /// <br/>or `xz`.</param>
    /// <param name="noOverwriteDirNonDir">If `1`, `true`, or `True` then it will be an error if unpacking the
    /// <br/>given content would cause an existing directory to be replaced with
    /// <br/>a non-directory and vice versa.</param>
    /// <param name="copyUIDGID">If `1`, `true`, then it will copy UID/GID maps to the dest file or
    /// <br/>dir</param>
    /// <returns>The content was extracted successfully</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task PutContainerArchiveAsync(string id, string path, FileParameter inputStream, string? noOverwriteDirNonDir = null, string? copyUIDGID = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Delete stopped containers
    /// </summary>
    /// <param name="filters">Filters to process on the prune list, encoded as JSON (a `map[string][]string`).
    /// <br/>
    /// <br/>Available filters:
    /// <br/>- `until=&lt;timestamp&gt;` Prune containers created before this timestamp. The `&lt;timestamp&gt;` can be Unix timestamps, date formatted timestamps, or Go duration strings (e.g. `10m`, `1h30m`) computed relative to the daemon machine’s time.
    /// <br/>- `label` (`label=&lt;key&gt;`, `label=&lt;key&gt;=&lt;value&gt;`, `label!=&lt;key&gt;`, or `label!=&lt;key&gt;=&lt;value&gt;`) Prune containers with (or without, in case `label!=...` is used) the specified labels.</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<ContainerPruneResponse> PruneAsync(string? filters = null, CancellationToken cancellationToken = default);

}