namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class TmpfsOptions
{
    /// <summary>
    /// The size for the tmpfs mount in bytes.
    /// </summary>

    [JsonPropertyName("SizeBytes")]
    public long? SizeBytes { get; set; } = default!;

    /// <summary>
    /// The permission mode for the tmpfs mount in an integer.
    /// </summary>

    [JsonPropertyName("Mode")]
    public int? Mode { get; set; } = default!;

    /// <summary>
    /// The options to be passed to the tmpfs mount. An array of arrays.
    /// <br/>Flag options should be provided as 1-length arrays. Other types
    /// <br/>should be provided as as 2-length arrays, where the first item is
    /// <br/>the key and the second the value.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Options")]
    public ICollection<ICollection<string>>? Options { get; set; } = default!;


}