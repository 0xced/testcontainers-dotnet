using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class IPAMConfig
{

    [JsonPropertyName("Subnet")]
    public string? Subnet { get; set; } = default!;


    [JsonPropertyName("IPRange")]
    public string? IPRange { get; set; } = default!;


    [JsonPropertyName("Gateway")]
    public string? Gateway { get; set; } = default!;


    [JsonPropertyName("AuxiliaryAddresses")]
    public System.Collections.Generic.IDictionary<string, string>? AuxiliaryAddresses { get; set; } = default!;


}