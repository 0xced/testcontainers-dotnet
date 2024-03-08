using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EndpointPortConfig
{

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;


    [JsonPropertyName("Protocol")]
    [JsonConverter(typeof(JsonEnumMemberConverter<EndpointPortConfigProtocol>))]
    public EndpointPortConfigProtocol? Protocol { get; set; } = default!;

    /// <summary>
    /// The port inside the container.
    /// </summary>

    [JsonPropertyName("TargetPort")]
    public int? TargetPort { get; set; } = default!;

    /// <summary>
    /// The port on the swarm hosts.
    /// </summary>

    [JsonPropertyName("PublishedPort")]
    public int? PublishedPort { get; set; } = default!;

    /// <summary>
    /// The mode in which port is published.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>- "ingress" makes the target port accessible on every node,
    /// <br/>  regardless of whether there is a task for the service running on
    /// <br/>  that node or not.
    /// <br/>- "host" bypasses the routing mesh and publish the port directly on
    /// <br/>  the swarm node where that service is running.
    /// <br/>
    /// </summary>

    [JsonPropertyName("PublishMode")]
    [JsonConverter(typeof(JsonEnumMemberConverter<EndpointPortConfigPublishMode>))]
    public EndpointPortConfigPublishMode? PublishMode { get; set; } = DockerEngine.EndpointPortConfigPublishMode.Ingress;


}