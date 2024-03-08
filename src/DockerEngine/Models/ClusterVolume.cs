using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Options and information specific to, and only present on, Swarm CSI
/// <br/>cluster volumes.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ClusterVolume
{
    /// <summary>
    /// The Swarm ID of this volume. Because cluster volumes are Swarm
    /// <br/>objects, they have an ID, unlike non-cluster volumes. This ID can
    /// <br/>be used to refer to the Volume instead of the name.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ID")]
    public string? ID { get; set; } = default!;


    [JsonPropertyName("Version")]
    public ObjectVersion? Version { get; set; } = default!;


    [JsonPropertyName("CreatedAt")]
    public string? CreatedAt { get; set; } = default!;


    [JsonPropertyName("UpdatedAt")]
    public string? UpdatedAt { get; set; } = default!;


    [JsonPropertyName("Spec")]
    public ClusterVolumeSpec? Spec { get; set; } = default!;

    /// <summary>
    /// Information about the global status of the volume.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Info")]
    public Info? Info { get; set; } = default!;

    /// <summary>
    /// The status of the volume as it pertains to its publishing and use on
    /// <br/>specific nodes
    /// <br/>
    /// </summary>

    [JsonPropertyName("PublishStatus")]
    public ICollection<PublishStatus>? PublishStatus { get; set; } = default!;


}