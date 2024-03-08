using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Represents a peer-node in the swarm
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PeerNode
{
    /// <summary>
    /// Unique identifier of for this node in the swarm.
    /// </summary>

    [JsonPropertyName("NodeID")]
    public string? NodeID { get; set; } = default!;

    /// <summary>
    /// IP address and ports at which this node can be reached.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Addr")]
    public string? Addr { get; set; } = default!;


}