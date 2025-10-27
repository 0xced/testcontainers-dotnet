namespace DockerEngine;

/// <summary>
/// A descriptor struct containing digest, media type, and size, as defined in
/// <br/>the [OCI Content Descriptors Specification](https://github.com/opencontainers/image-spec/blob/v1.0.1/descriptor.md).
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
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

    /// <summary>
    /// List of URLs from which this object MAY be downloaded.
    /// </summary>

    [JsonPropertyName("urls")]
    public ICollection<System.Uri>? Urls { get; set; } = default!;

    /// <summary>
    /// Arbitrary metadata relating to the targeted content.
    /// </summary>

    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; } = default!;

    /// <summary>
    /// Data is an embedding of the targeted content. This is encoded as a base64
    /// <br/>string when marshalled to JSON (automatically, by encoding/json). If
    /// <br/>present, Data can be used directly to avoid fetching the targeted content.
    /// </summary>

    [JsonPropertyName("data")]
    public string? Data { get; set; } = default!;


    [JsonPropertyName("platform")]
    public OCIPlatform? Platform { get; set; } = default!;

    /// <summary>
    /// ArtifactType is the IANA media type of this artifact.
    /// </summary>

    [JsonPropertyName("artifactType")]
    public string? ArtifactType { get; set; } = default!;


}