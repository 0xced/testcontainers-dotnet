namespace DockerEngine;

/// <summary>
/// Change in the container's filesystem.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class FilesystemChange
{
    /// <summary>
    /// Path to file or directory that has changed.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Path")]
    public string Path { get; set; } = default!;


    [JsonPropertyName("Kind")]
    public ChangeType Kind { get; set; } = default!;


}