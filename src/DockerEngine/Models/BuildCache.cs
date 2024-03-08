using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// BuildCache contains information about a build cache record.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class BuildCache
{
    /// <summary>
    /// Unique ID of the build cache record.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ID")]
    public string? ID { get; set; } = default!;

    /// <summary>
    /// ID of the parent build cache record.
    /// <br/>
    /// <br/>&gt; **Deprecated**: This field is deprecated, and omitted if empty.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Parent")]
    public string? Parent { get; set; } = default!;

    /// <summary>
    /// List of parent build cache record IDs.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Parents")]
    public System.Collections.Generic.ICollection<string>? Parents { get; set; } = default!;

    /// <summary>
    /// Cache record type.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Type")]
    [JsonConverter(typeof(JsonEnumMemberConverter<BuildCacheType>))]
    public BuildCacheType? Type { get; set; } = default!;

    /// <summary>
    /// Description of the build-step that produced the build cache.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Description")]
    public string? Description { get; set; } = default!;

    /// <summary>
    /// Indicates if the build cache is in use.
    /// <br/>
    /// </summary>

    [JsonPropertyName("InUse")]
    public bool? InUse { get; set; } = default!;

    /// <summary>
    /// Indicates if the build cache is shared.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Shared")]
    public bool? Shared { get; set; } = default!;

    /// <summary>
    /// Amount of disk space used by the build cache (in bytes).
    /// <br/>
    /// </summary>

    [JsonPropertyName("Size")]
    public int? Size { get; set; } = default!;

    /// <summary>
    /// Date and time at which the build cache was created in
    /// <br/>[RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) format with nano-seconds.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CreatedAt")]
    public string? CreatedAt { get; set; } = default!;

    /// <summary>
    /// Date and time at which the build cache was last used in
    /// <br/>[RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) format with nano-seconds.
    /// <br/>
    /// </summary>

    [JsonPropertyName("LastUsedAt")]
    public string? LastUsedAt { get; set; } = default!;


    [JsonPropertyName("UsageCount")]
    public int? UsageCount { get; set; } = default!;


}