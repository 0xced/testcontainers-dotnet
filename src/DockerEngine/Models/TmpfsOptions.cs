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


}