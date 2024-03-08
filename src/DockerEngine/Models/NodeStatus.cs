using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// NodeStatus represents the status of a node.
/// <br/>
/// <br/>It provides the current status of the node, as seen by the manager.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class NodeStatus
{

    [JsonPropertyName("State")]
    [JsonConverter(typeof(JsonEnumMemberConverter<NodeState>))]
    public NodeState? State { get; set; } = default!;


    [JsonPropertyName("Message")]
    public string? Message { get; set; } = default!;

    /// <summary>
    /// IP address of the node.
    /// </summary>

    [JsonPropertyName("Addr")]
    public string? Addr { get; set; } = default!;


}