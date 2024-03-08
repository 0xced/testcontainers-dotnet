using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// represents the port status of a task's host ports whose service has published host ports
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PortStatus
{

    [JsonPropertyName("Ports")]
    public System.Collections.Generic.ICollection<EndpointPortConfig>? Ports { get; set; } = default!;


}