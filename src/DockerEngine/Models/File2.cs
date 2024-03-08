using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class File2
{
    /// <summary>
    /// Name represents the final filename in the filesystem.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;

    /// <summary>
    /// UID represents the file UID.
    /// </summary>

    [JsonPropertyName("UID")]
    public string? UID { get; set; } = default!;

    /// <summary>
    /// GID represents the file GID.
    /// </summary>

    [JsonPropertyName("GID")]
    public string? GID { get; set; } = default!;

    /// <summary>
    /// Mode represents the FileMode of the file.
    /// </summary>

    [JsonPropertyName("Mode")]
    public int? Mode { get; set; } = default!;


}