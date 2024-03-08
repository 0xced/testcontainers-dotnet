using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Ulimits2
{
    /// <summary>
    /// Name of ulimit
    /// </summary>

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;

    /// <summary>
    /// Soft limit
    /// </summary>

    [JsonPropertyName("Soft")]
    public int? Soft { get; set; } = default!;

    /// <summary>
    /// Hard limit
    /// </summary>

    [JsonPropertyName("Hard")]
    public int? Hard { get; set; } = default!;


}