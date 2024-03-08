using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Node
{

    [JsonPropertyName("ID")]
    public string? ID { get; set; } = default!;


    [JsonPropertyName("Version")]
    public ObjectVersion? Version { get; set; } = default!;

    /// <summary>
    /// Date and time at which the node was added to the swarm in
    /// <br/>[RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) format with nano-seconds.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CreatedAt")]
    public string? CreatedAt { get; set; } = default!;

    /// <summary>
    /// Date and time at which the node was last updated in
    /// <br/>[RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) format with nano-seconds.
    /// <br/>
    /// </summary>

    [JsonPropertyName("UpdatedAt")]
    public string? UpdatedAt { get; set; } = default!;


    [JsonPropertyName("Spec")]
    public NodeSpec? Spec { get; set; } = default!;


    [JsonPropertyName("Description")]
    public NodeDescription? Description { get; set; } = default!;


    [JsonPropertyName("Status")]
    public NodeStatus? Status { get; set; } = default!;


    [JsonPropertyName("ManagerStatus")]
    public ManagerStatus? ManagerStatus { get; set; } = default!;


}