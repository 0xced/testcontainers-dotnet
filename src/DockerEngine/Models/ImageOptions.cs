namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class ImageOptions
{
    /// <summary>
    /// Source path inside the image. Must be relative without any back traversals.
    /// </summary>

    [JsonPropertyName("Subpath")]
    public string? Subpath { get; set; } = default!;


}