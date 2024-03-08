using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class IPAM
{
    /// <summary>
    /// Name of the IPAM driver to use.
    /// </summary>

    [JsonPropertyName("Driver")]
    public string? Driver { get; set; } = "default";

    /// <summary>
    /// List of IPAM configuration options, specified as a map:
    /// <br/>
    /// <br/>```
    /// <br/>{"Subnet": &lt;CIDR&gt;, "IPRange": &lt;CIDR&gt;, "Gateway": &lt;IP address&gt;, "AuxAddress": &lt;device_name:IP address&gt;}
    /// <br/>```
    /// <br/>
    /// </summary>

    [JsonPropertyName("Config")]
    public System.Collections.Generic.ICollection<IPAMConfig>? Config { get; set; } = default!;

    /// <summary>
    /// Driver-specific options, specified as a map.
    /// </summary>

    [JsonPropertyName("Options")]
    public System.Collections.Generic.IDictionary<string, string>? Options { get; set; } = default!;


}