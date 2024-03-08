using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
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
    public System.Collections.Generic.IDictionary<string, string>? Labels { get; set; } = default!;

    /// <summary>
    /// Map of driver specific options
    /// </summary>

    [JsonPropertyName("DriverConfig")]
    public DriverConfig? DriverConfig { get; set; } = default!;


}