using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Mount
{
    /// <summary>
    /// Container path.
    /// </summary>

    [JsonPropertyName("Target")]
    public string? Target { get; set; } = default!;

    /// <summary>
    /// Mount source (e.g. a volume name, a host path).
    /// </summary>

    [JsonPropertyName("Source")]
    public string? Source { get; set; } = default!;

    /// <summary>
    /// The mount type. Available types:
    /// <br/>
    /// <br/>- `bind` Mounts a file or directory from the host into the container. Must exist prior to creating the container.
    /// <br/>- `volume` Creates a volume with the given name and options (or uses a pre-existing volume with the same name and options). These are **not** removed when the container is removed.
    /// <br/>- `tmpfs` Create a tmpfs with the given options. The mount source cannot be specified for tmpfs.
    /// <br/>- `npipe` Mounts a named pipe from the host into the container. Must exist prior to creating the container.
    /// <br/>- `cluster` a Swarm cluster volume
    /// <br/>
    /// </summary>

    [JsonPropertyName("Type")]
    [JsonConverter(typeof(JsonEnumMemberConverter<MountType>))]
    public MountType? Type { get; set; } = default!;

    /// <summary>
    /// Whether the mount should be read-only.
    /// </summary>

    [JsonPropertyName("ReadOnly")]
    public bool? ReadOnly { get; set; } = default!;

    /// <summary>
    /// The consistency requirement for the mount: `default`, `consistent`, `cached`, or `delegated`.
    /// </summary>

    [JsonPropertyName("Consistency")]
    public string? Consistency { get; set; } = default!;

    /// <summary>
    /// Optional configuration for the `bind` type.
    /// </summary>

    [JsonPropertyName("BindOptions")]
    public BindOptions? BindOptions { get; set; } = default!;

    /// <summary>
    /// Optional configuration for the `volume` type.
    /// </summary>

    [JsonPropertyName("VolumeOptions")]
    public VolumeOptions? VolumeOptions { get; set; } = default!;

    /// <summary>
    /// Optional configuration for the `tmpfs` type.
    /// </summary>

    [JsonPropertyName("TmpfsOptions")]
    public TmpfsOptions? TmpfsOptions { get; set; } = default!;


}