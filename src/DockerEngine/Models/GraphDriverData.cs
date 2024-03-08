using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Information about the storage driver used to store the container's and
/// <br/>image's filesystem.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class GraphDriverData
{
    /// <summary>
    /// Name of the storage driver.
    /// </summary>

    [JsonPropertyName("Name")]
    public string Name { get; set; } = default!;

    /// <summary>
    /// Low-level storage metadata, provided as key/value pairs.
    /// <br/>
    /// <br/>This information is driver-specific, and depends on the storage-driver
    /// <br/>in use, and should be used for informational purposes only.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Data")]
    public System.Collections.Generic.IDictionary<string, string> Data { get; set; } = new System.Collections.Generic.Dictionary<string, string>();


}