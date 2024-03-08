using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class NodeSpec
{
    /// <summary>
    /// Name for the node.
    /// </summary>

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;

    /// <summary>
    /// User-defined key/value metadata.
    /// </summary>

    [JsonPropertyName("Labels")]
    public System.Collections.Generic.IDictionary<string, string>? Labels { get; set; } = default!;

    /// <summary>
    /// Role of the node.
    /// </summary>

    [JsonPropertyName("Role")]
    [JsonConverter(typeof(JsonEnumMemberConverter<NodeSpecRole>))]
    public NodeSpecRole? Role { get; set; } = default!;

    /// <summary>
    /// Availability of the node.
    /// </summary>

    [JsonPropertyName("Availability")]
    [JsonConverter(typeof(JsonEnumMemberConverter<NodeSpecAvailability>))]
    public NodeSpecAvailability? Availability { get; set; } = default!;


}