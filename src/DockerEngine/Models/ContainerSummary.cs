using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerSummary
{
    /// <summary>
    /// The ID of this container
    /// </summary>

    [JsonPropertyName("Id")]
    public string? Id { get; set; } = default!;

    /// <summary>
    /// The names that this container has been given
    /// </summary>

    [JsonPropertyName("Names")]
    public ICollection<string>? Names { get; set; } = default!;

    /// <summary>
    /// The name of the image used when creating this container
    /// </summary>

    [JsonPropertyName("Image")]
    public string? Image { get; set; } = default!;

    /// <summary>
    /// The ID of the image that this container was created from
    /// </summary>

    [JsonPropertyName("ImageID")]
    public string? ImageID { get; set; } = default!;

    /// <summary>
    /// Command to run when starting the container
    /// </summary>

    [JsonPropertyName("Command")]
    public string? Command { get; set; } = default!;

    /// <summary>
    /// When the container was created
    /// </summary>

    [JsonPropertyName("Created")]
    public long? Created { get; set; } = default!;

    /// <summary>
    /// The ports exposed by this container
    /// </summary>

    [JsonPropertyName("Ports")]
    public ICollection<Port>? Ports { get; set; } = default!;

    /// <summary>
    /// The size of files that have been created or changed by this container
    /// </summary>

    [JsonPropertyName("SizeRw")]
    public long? SizeRw { get; set; } = default!;

    /// <summary>
    /// The total size of all the files in this container
    /// </summary>

    [JsonPropertyName("SizeRootFs")]
    public long? SizeRootFs { get; set; } = default!;

    /// <summary>
    /// User-defined key/value metadata.
    /// </summary>

    [JsonPropertyName("Labels")]
    public IDictionary<string, string>? Labels { get; set; } = default!;

    /// <summary>
    /// The state of this container (e.g. `Exited`)
    /// </summary>

    [JsonPropertyName("State")]
    public string? State { get; set; } = default!;

    /// <summary>
    /// Additional human-readable status of this container (e.g. `Exit 0`)
    /// </summary>

    [JsonPropertyName("Status")]
    public string? Status { get; set; } = default!;


    [JsonPropertyName("HostConfig")]
    public HostConfig2? HostConfig { get; set; } = default!;

    /// <summary>
    /// A summary of the container's network settings
    /// </summary>

    [JsonPropertyName("NetworkSettings")]
    public NetworkSettings2? NetworkSettings { get; set; } = default!;


    [JsonPropertyName("Mounts")]
    public ICollection<MountPoint>? Mounts { get; set; } = default!;


}