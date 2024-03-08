using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Info
{
    /// <summary>
    /// The capacity of the volume in bytes. A value of 0 indicates that
    /// <br/>the capacity is unknown.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CapacityBytes")]
    public long? CapacityBytes { get; set; } = default!;

    /// <summary>
    /// A map of strings to strings returned from the storage plugin when
    /// <br/>the volume is created.
    /// <br/>
    /// </summary>

    [JsonPropertyName("VolumeContext")]
    public IDictionary<string, string>? VolumeContext { get; set; } = default!;

    /// <summary>
    /// The ID of the volume as returned by the CSI storage plugin. This
    /// <br/>is distinct from the volume's ID as provided by Docker. This ID
    /// <br/>is never used by the user when communicating with Docker to refer
    /// <br/>to this volume. If the ID is blank, then the Volume has not been
    /// <br/>successfully created in the plugin yet.
    /// <br/>
    /// </summary>

    [JsonPropertyName("VolumeID")]
    public string? VolumeID { get; set; } = default!;

    /// <summary>
    /// The topology this volume is actually accessible from.
    /// <br/>
    /// </summary>

    [JsonPropertyName("AccessibleTopology")]
    public ICollection<Topology>? AccessibleTopology { get; set; } = default!;


}