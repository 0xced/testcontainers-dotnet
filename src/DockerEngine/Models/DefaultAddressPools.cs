namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class DefaultAddressPools
{
    /// <summary>
    /// The network address in CIDR format
    /// </summary>

    [JsonPropertyName("Base")]
    public string? Base { get; set; } = default!;

    /// <summary>
    /// The network pool size
    /// </summary>

    [JsonPropertyName("Size")]
    public int? Size { get; set; } = default!;


}