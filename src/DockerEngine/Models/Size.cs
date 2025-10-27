namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class Size
{
    /// <summary>
    /// Total is the total size (in bytes) of all the locally present
    /// <br/>data (both distributable and non-distributable) that's related to
    /// <br/>this manifest and its children.
    /// <br/>This equal to the sum of [Content] size AND all the sizes in the
    /// <br/>[Size] struct present in the Kind-specific data struct.
    /// <br/>For example, for an image kind (Kind == "image")
    /// <br/>this would include the size of the image content and unpacked
    /// <br/>image snapshots ([Size.Content] + [ImageData.Size.Unpacked]).
    /// <br/>
    /// </summary>

    [JsonPropertyName("Total")]
    public long Total { get; set; } = default!;

    /// <summary>
    /// Content is the size (in bytes) of all the locally present
    /// <br/>content in the content store (e.g. image config, layers)
    /// <br/>referenced by this manifest and its children.
    /// <br/>This only includes blobs in the content store.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Content")]
    public long Content { get; set; } = default!;


}