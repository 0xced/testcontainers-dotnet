namespace DockerEngine;

/// <summary>
/// Commit holds the Git-commit (SHA1) that a binary was built from, as
/// <br/>reported in the version-string of external tools, such as `containerd`,
/// <br/>or `runC`.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class Commit
{
    /// <summary>
    /// Actual commit ID of external tool.
    /// </summary>

    [JsonPropertyName("ID")]
    public string? ID { get; set; } = default!;


}