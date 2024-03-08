using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DNSConfig
{
    /// <summary>
    /// The IP addresses of the name servers.
    /// </summary>

    [JsonPropertyName("Nameservers")]
    public System.Collections.Generic.ICollection<string>? Nameservers { get; set; } = default!;

    /// <summary>
    /// A search list for host-name lookup.
    /// </summary>

    [JsonPropertyName("Search")]
    public System.Collections.Generic.ICollection<string>? Search { get; set; } = default!;

    /// <summary>
    /// A list of internal resolver variables to be modified (e.g.,
    /// <br/>`debug`, `ndots:3`, etc.).
    /// <br/>
    /// </summary>

    [JsonPropertyName("Options")]
    public System.Collections.Generic.ICollection<string>? Options { get; set; } = default!;


}