namespace DockerEngine;

/// <summary>
/// represents the port status of a task's host ports whose service has published host ports
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class PortStatus
{

    [JsonPropertyName("Ports")]
    public ICollection<EndpointPortConfig>? Ports { get; set; } = default!;


}