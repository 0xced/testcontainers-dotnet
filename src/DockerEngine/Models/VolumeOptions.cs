namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class VolumeOptions
{
    /// <summary>
    /// Populate volume with data from the target.
    /// </summary>

    [JsonPropertyName("NoCopy")]
    public bool? NoCopy { get; set; } = false;

    /// <summary>
    /// User-defined key/value metadata.
    /// </summary>

    [JsonPropertyName("Labels")]
    public IDictionary<string, string>? Labels { get; set; } = default!;

    /// <summary>
    /// Map of driver specific options
    /// </summary>

    [JsonPropertyName("DriverConfig")]
    public DriverConfig? DriverConfig { get; set; } = default!;

    /// <summary>
    /// Source path inside the volume. Must be relative without any back traversals.
    /// </summary>

    [JsonPropertyName("Subpath")]
    public string? Subpath { get; set; } = default!;


}