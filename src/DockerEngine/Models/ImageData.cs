namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class ImageData
{
    /// <summary>
    /// OCI platform of the image. This will be the platform specified in the
    /// <br/>manifest descriptor from the index/manifest list.
    /// <br/>If it's not available, it will be obtained from the image config.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Platform")]
    public OCIPlatform? Platform { get; set; } = default!;

    /// <summary>
    /// The IDs of the containers that are using this image.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Containers")]
    public ICollection<string> Containers { get; set; } = new List<string>();


    [JsonPropertyName("Size")]
    public Size2 Size { get; set; } = new Size2();


}