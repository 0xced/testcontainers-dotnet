using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Volume list response
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class VolumeListResponse
{
    /// <summary>
    /// List of volumes
    /// </summary>

    [JsonPropertyName("Volumes")]
    public System.Collections.Generic.ICollection<Volume>? Volumes { get; set; } = default!;

    /// <summary>
    /// Warnings that occurred when fetching the list of volumes.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Warnings")]
    public System.Collections.Generic.ICollection<string>? Warnings { get; set; } = default!;


}