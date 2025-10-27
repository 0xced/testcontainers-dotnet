namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class ThrottleDevice
{
    /// <summary>
    /// Device path
    /// </summary>

    [JsonPropertyName("Path")]
    public string? Path { get; set; } = default!;

    /// <summary>
    /// Rate
    /// </summary>

    [JsonPropertyName("Rate")]
    public long? Rate { get; set; } = default!;


}