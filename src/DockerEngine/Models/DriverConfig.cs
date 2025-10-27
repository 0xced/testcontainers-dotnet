namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class DriverConfig
{
    /// <summary>
    /// Name of the driver to use to create the volume.
    /// </summary>

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;

    /// <summary>
    /// key/value map of driver specific options.
    /// </summary>

    [JsonPropertyName("Options")]
    public IDictionary<string, string>? Options { get; set; } = default!;


}