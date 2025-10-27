namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class Size2
{
    /// <summary>
    /// Unpacked is the size (in bytes) of the locally unpacked
    /// <br/>(uncompressed) image content that's directly usable by the containers
    /// <br/>running this image.
    /// <br/>It's independent of the distributable content - e.g.
    /// <br/>the image might still have an unpacked data that's still used by
    /// <br/>some container even when the distributable/compressed content is
    /// <br/>already gone.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Unpacked")]
    public long Unpacked { get; set; } = default!;


}