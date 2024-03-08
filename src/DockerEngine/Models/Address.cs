using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Address represents an IPv4 or IPv6 IP address.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Address
{
    /// <summary>
    /// IP address.
    /// </summary>

    [JsonPropertyName("Addr")]
    public string? Addr { get; set; } = default!;

    /// <summary>
    /// Mask length of the IP address.
    /// </summary>

    [JsonPropertyName("PrefixLen")]
    public int? PrefixLen { get; set; } = default!;


}