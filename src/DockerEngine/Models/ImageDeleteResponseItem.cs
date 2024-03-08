using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ImageDeleteResponseItem
{
    /// <summary>
    /// The image ID of an image that was untagged
    /// </summary>

    [JsonPropertyName("Untagged")]
    public string? Untagged { get; set; } = default!;

    /// <summary>
    /// The image ID of an image that was deleted
    /// </summary>

    [JsonPropertyName("Deleted")]
    public string? Deleted { get; set; } = default!;


}