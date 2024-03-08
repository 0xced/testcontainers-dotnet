using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Commit holds the Git-commit (SHA1) that a binary was built from, as
/// <br/>reported in the version-string of external tools, such as `containerd`,
/// <br/>or `runC`.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Commit
{
    /// <summary>
    /// Actual commit ID of external tool.
    /// </summary>

    [JsonPropertyName("ID")]
    public string? ID { get; set; } = default!;

    /// <summary>
    /// Commit ID of external tool expected by dockerd as set at build time.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Expected")]
    public string? Expected { get; set; } = default!;


}