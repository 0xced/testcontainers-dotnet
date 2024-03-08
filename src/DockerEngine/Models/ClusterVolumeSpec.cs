using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Cluster-specific options used to create the volume.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ClusterVolumeSpec
{
    /// <summary>
    /// Group defines the volume group of this volume. Volumes belonging to
    /// <br/>the same group can be referred to by group name when creating
    /// <br/>Services.  Referring to a volume by group instructs Swarm to treat
    /// <br/>volumes in that group interchangeably for the purpose of scheduling.
    /// <br/>Volumes with an empty string for a group technically all belong to
    /// <br/>the same, emptystring group.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Group")]
    public string? Group { get; set; } = default!;

    /// <summary>
    /// Defines how the volume is used by tasks.
    /// <br/>
    /// </summary>

    [JsonPropertyName("AccessMode")]
    public AccessMode? AccessMode { get; set; } = default!;


}