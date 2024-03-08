using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// A descriptor struct containing digest, media type, and size, as defined in
/// <br/>the [OCI Content Descriptors Specification](https://github.com/opencontainers/image-spec/blob/v1.0.1/descriptor.md).
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OCIDescriptor
{
    /// <summary>
    /// The media type of the object this schema refers to.
    /// <br/>
    /// </summary>

    [JsonPropertyName("mediaType")]
    public string? MediaType { get; set; } = default!;

    /// <summary>
    /// The digest of the targeted content.
    /// <br/>
    /// </summary>

    [JsonPropertyName("digest")]
    public string? Digest { get; set; } = default!;

    /// <summary>
    /// The size in bytes of the blob.
    /// <br/>
    /// </summary>

    [JsonPropertyName("size")]
    public long? Size { get; set; } = default!;


}