using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class Endpoint
{

    [JsonPropertyName("Spec")]
    public EndpointSpec? Spec { get; set; } = default!;


    [JsonPropertyName("Ports")]
    public ICollection<EndpointPortConfig>? Ports { get; set; } = default!;


    [JsonPropertyName("VirtualIPs")]
    public ICollection<VirtualIPs>? VirtualIPs { get; set; } = default!;


}