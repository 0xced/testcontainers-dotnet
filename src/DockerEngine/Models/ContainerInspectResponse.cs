using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerInspectResponse
{
    /// <summary>
    /// The ID of the container
    /// </summary>

    [JsonPropertyName("Id")]
    public string? Id { get; set; } = default!;

    /// <summary>
    /// The time the container was created
    /// </summary>

    [JsonPropertyName("Created")]
    public string? Created { get; set; } = default!;

    /// <summary>
    /// The path to the command being run
    /// </summary>

    [JsonPropertyName("Path")]
    public string? Path { get; set; } = default!;

    /// <summary>
    /// The arguments to the command being run
    /// </summary>

    [JsonPropertyName("Args")]
    public System.Collections.Generic.ICollection<string>? Args { get; set; } = default!;


    [JsonPropertyName("State")]
    public ContainerState? State { get; set; } = default!;

    /// <summary>
    /// The container's image ID
    /// </summary>

    [JsonPropertyName("Image")]
    public string? Image { get; set; } = default!;


    [JsonPropertyName("ResolvConfPath")]
    public string? ResolvConfPath { get; set; } = default!;


    [JsonPropertyName("HostnamePath")]
    public string? HostnamePath { get; set; } = default!;


    [JsonPropertyName("HostsPath")]
    public string? HostsPath { get; set; } = default!;


    [JsonPropertyName("LogPath")]
    public string? LogPath { get; set; } = default!;


    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;


    [JsonPropertyName("RestartCount")]
    public int? RestartCount { get; set; } = default!;


    [JsonPropertyName("Driver")]
    public string? Driver { get; set; } = default!;


    [JsonPropertyName("Platform")]
    public string? Platform { get; set; } = default!;


    [JsonPropertyName("MountLabel")]
    public string? MountLabel { get; set; } = default!;


    [JsonPropertyName("ProcessLabel")]
    public string? ProcessLabel { get; set; } = default!;


    [JsonPropertyName("AppArmorProfile")]
    public string? AppArmorProfile { get; set; } = default!;

    /// <summary>
    /// IDs of exec instances that are running in the container.
    /// </summary>

    [JsonPropertyName("ExecIDs")]
    public System.Collections.Generic.ICollection<string>? ExecIDs { get; set; } = default!;


    [JsonPropertyName("HostConfig")]
    public HostConfig? HostConfig { get; set; } = default!;


    [JsonPropertyName("GraphDriver")]
    public GraphDriverData? GraphDriver { get; set; } = default!;

    /// <summary>
    /// The size of files that have been created or changed by this
    /// <br/>container.
    /// <br/>
    /// </summary>

    [JsonPropertyName("SizeRw")]
    public long? SizeRw { get; set; } = default!;

    /// <summary>
    /// The total size of all the files in this container.
    /// </summary>

    [JsonPropertyName("SizeRootFs")]
    public long? SizeRootFs { get; set; } = default!;


    [JsonPropertyName("Mounts")]
    public System.Collections.Generic.ICollection<MountPoint>? Mounts { get; set; } = default!;


    [JsonPropertyName("Config")]
    public ContainerConfig? Config { get; set; } = default!;


    [JsonPropertyName("NetworkSettings")]
    public NetworkSettings? NetworkSettings { get; set; } = default!;


}