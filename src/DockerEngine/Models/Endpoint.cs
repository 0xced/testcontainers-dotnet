using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Endpoint
{

    [JsonPropertyName("Spec")]
    public EndpointSpec? Spec { get; set; } = default!;


    [JsonPropertyName("Ports")]
    public System.Collections.Generic.ICollection<EndpointPortConfig>? Ports { get; set; } = default!;


    [JsonPropertyName("VirtualIPs")]
    public System.Collections.Generic.ICollection<VirtualIPs>? VirtualIPs { get; set; } = default!;


}