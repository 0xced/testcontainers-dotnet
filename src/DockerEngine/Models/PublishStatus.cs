using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PublishStatus
{
    /// <summary>
    /// The ID of the Swarm node the volume is published on.
    /// <br/>
    /// </summary>

    [JsonPropertyName("NodeID")]
    public string? NodeID { get; set; } = default!;

    /// <summary>
    /// The published state of the volume.
    /// <br/>* `pending-publish` The volume should be published to this node, but the call to the controller plugin to do so has not yet been successfully completed.
    /// <br/>* `published` The volume is published successfully to the node.
    /// <br/>* `pending-node-unpublish` The volume should be unpublished from the node, and the manager is awaiting confirmation from the worker that it has done so.
    /// <br/>* `pending-controller-unpublish` The volume is successfully unpublished from the node, but has not yet been successfully unpublished on the controller.
    /// <br/>
    /// </summary>

    [JsonPropertyName("State")]
    [JsonConverter(typeof(JsonEnumMemberConverter<PublishStatusState>))]
    public PublishStatusState? State { get; set; } = default!;

    /// <summary>
    /// A map of strings to strings returned by the CSI controller
    /// <br/>plugin when a volume is published.
    /// <br/>
    /// </summary>

    [JsonPropertyName("PublishContext")]
    public System.Collections.Generic.IDictionary<string, string>? PublishContext { get; set; } = default!;


}