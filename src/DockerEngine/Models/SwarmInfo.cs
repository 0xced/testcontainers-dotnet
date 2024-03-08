using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Represents generic information about swarm.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SwarmInfo
{
    /// <summary>
    /// Unique identifier of for this node in the swarm.
    /// </summary>

    [JsonPropertyName("NodeID")]
    public string? NodeID { get; set; } = "";

    /// <summary>
    /// IP address at which this node can be reached by other nodes in the
    /// <br/>swarm.
    /// <br/>
    /// </summary>

    [JsonPropertyName("NodeAddr")]
    public string? NodeAddr { get; set; } = "";


    [JsonPropertyName("LocalNodeState")]
    [JsonConverter(typeof(JsonEnumMemberConverter<LocalNodeState>))]
    public LocalNodeState? LocalNodeState { get; set; } = default!;


    [JsonPropertyName("ControlAvailable")]
    public bool? ControlAvailable { get; set; } = false;


    [JsonPropertyName("Error")]
    public string? Error { get; set; } = "";

    /// <summary>
    /// List of ID's and addresses of other managers in the swarm.
    /// <br/>
    /// </summary>

    [JsonPropertyName("RemoteManagers")]
    public ICollection<PeerNode>? RemoteManagers { get; set; } = default!;

    /// <summary>
    /// Total number of nodes in the swarm.
    /// </summary>

    [JsonPropertyName("Nodes")]
    public int? Nodes { get; set; } = default!;

    /// <summary>
    /// Total number of managers in the swarm.
    /// </summary>

    [JsonPropertyName("Managers")]
    public int? Managers { get; set; } = default!;


    [JsonPropertyName("Cluster")]
    public ClusterInfo? Cluster { get; set; } = default!;


}