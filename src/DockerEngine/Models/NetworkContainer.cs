using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class NetworkContainer
{

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;


    [JsonPropertyName("EndpointID")]
    public string? EndpointID { get; set; } = default!;


    [JsonPropertyName("MacAddress")]
    public string? MacAddress { get; set; } = default!;


    [JsonPropertyName("IPv4Address")]
    public string? IPv4Address { get; set; } = default!;


    [JsonPropertyName("IPv6Address")]
    public string? IPv6Address { get; set; } = default!;


}