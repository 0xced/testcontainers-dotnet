namespace DockerEngine;

/// <summary>
/// EndpointIPAMConfig represents an endpoint's IPAM configuration.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class EndpointIPAMConfig
{

    [JsonPropertyName("IPv4Address")]
    public string? IPv4Address { get; set; } = default!;


    [JsonPropertyName("IPv6Address")]
    public string? IPv6Address { get; set; } = default!;


    [JsonPropertyName("LinkLocalIPs")]
    public ICollection<string>? LinkLocalIPs { get; set; } = default!;


}