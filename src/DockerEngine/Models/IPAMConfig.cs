namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class IPAMConfig
{

    [JsonPropertyName("Subnet")]
    public string? Subnet { get; set; } = default!;


    [JsonPropertyName("IPRange")]
    public string? IPRange { get; set; } = default!;


    [JsonPropertyName("Gateway")]
    public string? Gateway { get; set; } = default!;


    [JsonPropertyName("AuxiliaryAddresses")]
    public IDictionary<string, string>? AuxiliaryAddresses { get; set; } = default!;


}