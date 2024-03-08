using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AccessibilityRequirements
{
    /// <summary>
    /// A list of required topologies, at least one of which the
    /// <br/>volume must be accessible from.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Requisite")]
    public ICollection<Topology>? Requisite { get; set; } = default!;

    /// <summary>
    /// A list of topologies that the volume should attempt to be
    /// <br/>provisioned in.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Preferred")]
    public ICollection<Topology>? Preferred { get; set; } = default!;


}