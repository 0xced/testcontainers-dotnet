namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class Endpoint
{

    [JsonPropertyName("Spec")]
    public EndpointSpec? Spec { get; set; } = default!;


    [JsonPropertyName("Ports")]
    public ICollection<EndpointPortConfig>? Ports { get; set; } = default!;


    [JsonPropertyName("VirtualIPs")]
    public ICollection<VirtualIPs>? VirtualIPs { get; set; } = default!;


}