namespace DockerEngine;

/// <summary>
/// ImageManifestSummary represents a summary of an image manifest.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class ImageManifestSummary
{
    /// <summary>
    /// ID is the content-addressable ID of an image and is the same as the
    /// <br/>digest of the image manifest.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ID")]
    public string ID { get; set; } = default!;


    [JsonPropertyName("Descriptor")]
    public OCIDescriptor Descriptor { get; set; } = new OCIDescriptor();

    /// <summary>
    /// Indicates whether all the child content (image config, layers) is fully available locally.
    /// </summary>

    [JsonPropertyName("Available")]
    public bool Available { get; set; } = default!;


    [JsonPropertyName("Size")]
    public Size Size { get; set; } = new Size();

    /// <summary>
    /// The kind of the manifest.
    /// <br/>
    /// <br/>kind         | description
    /// <br/>-------------|-----------------------------------------------------------
    /// <br/>image        | Image manifest that can be used to start a container.
    /// <br/>attestation  | Attestation manifest produced by the Buildkit builder for a specific image manifest.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Kind")]
    [JsonConverter(typeof(JsonEnumMemberConverter<ImageManifestSummaryKind>))]
    public ImageManifestSummaryKind Kind { get; set; } = default!;

    /// <summary>
    /// The image data for the image manifest.
    /// <br/>This field is only populated when Kind is "image".
    /// <br/>
    /// </summary>

    [JsonPropertyName("ImageData")]
    public ImageData? ImageData { get; set; } = default!;

    /// <summary>
    /// The image data for the attestation manifest.
    /// <br/>This field is only populated when Kind is "attestation".
    /// <br/>
    /// </summary>

    [JsonPropertyName("AttestationData")]
    public AttestationData? AttestationData { get; set; } = default!;


}