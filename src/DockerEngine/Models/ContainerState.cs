using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// ContainerState stores container's running state. It's part of ContainerJSONBase
/// <br/>and will be returned by the "inspect" command.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerState
{
    /// <summary>
    /// String representation of the container state. Can be one of "created",
    /// <br/>"running", "paused", "restarting", "removing", "exited", or "dead".
    /// <br/>
    /// </summary>

    [JsonPropertyName("Status")]
    [JsonConverter(typeof(JsonEnumMemberConverter<ContainerStateStatus>))]
    public ContainerStateStatus? Status { get; set; } = default!;

    /// <summary>
    /// Whether this container is running.
    /// <br/>
    /// <br/>Note that a running container can be _paused_. The `Running` and `Paused`
    /// <br/>booleans are not mutually exclusive:
    /// <br/>
    /// <br/>When pausing a container (on Linux), the freezer cgroup is used to suspend
    /// <br/>all processes in the container. Freezing the process requires the process to
    /// <br/>be running. As a result, paused containers are both `Running` _and_ `Paused`.
    /// <br/>
    /// <br/>Use the `Status` field instead to determine if a container's state is "running".
    /// <br/>
    /// </summary>

    [JsonPropertyName("Running")]
    public bool? Running { get; set; } = default!;

    /// <summary>
    /// Whether this container is paused.
    /// </summary>

    [JsonPropertyName("Paused")]
    public bool? Paused { get; set; } = default!;

    /// <summary>
    /// Whether this container is restarting.
    /// </summary>

    [JsonPropertyName("Restarting")]
    public bool? Restarting { get; set; } = default!;

    /// <summary>
    /// Whether a process within this container has been killed because it ran
    /// <br/>out of memory since the container was last started.
    /// <br/>
    /// </summary>

    [JsonPropertyName("OOMKilled")]
    public bool? OOMKilled { get; set; } = default!;


    [JsonPropertyName("Dead")]
    public bool? Dead { get; set; } = default!;

    /// <summary>
    /// The process ID of this container
    /// </summary>

    [JsonPropertyName("Pid")]
    public int? Pid { get; set; } = default!;

    /// <summary>
    /// The last exit code of this container
    /// </summary>

    [JsonPropertyName("ExitCode")]
    public int? ExitCode { get; set; } = default!;


    [JsonPropertyName("Error")]
    public string? Error { get; set; } = default!;

    /// <summary>
    /// The time when this container was last started.
    /// </summary>

    [JsonPropertyName("StartedAt")]
    public string? StartedAt { get; set; } = default!;

    /// <summary>
    /// The time when this container last exited.
    /// </summary>

    [JsonPropertyName("FinishedAt")]
    public string? FinishedAt { get; set; } = default!;


    [JsonPropertyName("Health")]
    public Health? Health { get; set; } = default!;


}