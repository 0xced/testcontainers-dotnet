namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class ImageSummary
{
    /// <summary>
    /// ID is the content-addressable ID of an image.
    /// <br/>
    /// <br/>This identifier is a content-addressable digest calculated from the
    /// <br/>image's configuration (which includes the digests of layers used by
    /// <br/>the image).
    /// <br/>
    /// <br/>Note that this digest differs from the `RepoDigests` below, which
    /// <br/>holds digests of image manifests that reference the image.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Id")]
    public string Id { get; set; } = default!;

    /// <summary>
    /// ID of the parent image.
    /// <br/>
    /// <br/>Depending on how the image was created, this field may be empty and
    /// <br/>is only set for images that were built/created locally. This field
    /// <br/>is empty if the image was pulled from an image registry.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ParentId")]
    public string ParentId { get; set; } = default!;

    /// <summary>
    /// List of image names/tags in the local image cache that reference this
    /// <br/>image.
    /// <br/>
    /// <br/>Multiple image tags can refer to the same image, and this list may be
    /// <br/>empty if no tags reference the image, in which case the image is
    /// <br/>"untagged", in which case it can still be referenced by its ID.
    /// <br/>
    /// </summary>

    [JsonPropertyName("RepoTags")]
    public ICollection<string> RepoTags { get; set; } = new List<string>();

    /// <summary>
    /// List of content-addressable digests of locally available image manifests
    /// <br/>that the image is referenced from. Multiple manifests can refer to the
    /// <br/>same image.
    /// <br/>
    /// <br/>These digests are usually only available if the image was either pulled
    /// <br/>from a registry, or if the image was pushed to a registry, which is when
    /// <br/>the manifest is generated and its digest calculated.
    /// <br/>
    /// </summary>

    [JsonPropertyName("RepoDigests")]
    public ICollection<string> RepoDigests { get; set; } = new List<string>();

    /// <summary>
    /// Date and time at which the image was created as a Unix timestamp
    /// <br/>(number of seconds since EPOCH).
    /// <br/>
    /// </summary>

    [JsonPropertyName("Created")]
    public int Created { get; set; } = default!;

    /// <summary>
    /// Total size of the image including all layers it is composed of.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Size")]
    public long Size { get; set; } = default!;

    /// <summary>
    /// Total size of image layers that are shared between this image and other
    /// <br/>images.
    /// <br/>
    /// <br/>This size is not calculated by default. `-1` indicates that the value
    /// <br/>has not been set / calculated.
    /// <br/>
    /// </summary>

    [JsonPropertyName("SharedSize")]
    public long SharedSize { get; set; } = default!;

    /// <summary>
    /// User-defined key/value metadata.
    /// </summary>

    [JsonPropertyName("Labels")]
    public IDictionary<string, string> Labels { get; set; } = new Dictionary<string, string>();

    /// <summary>
    /// Number of containers using this image. Includes both stopped and running
    /// <br/>containers.
    /// <br/>
    /// <br/>`-1` indicates that the value has not been set / calculated.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Containers")]
    public int Containers { get; set; } = default!;

    /// <summary>
    /// Manifests is a list of manifests available in this image.
    /// <br/>It provides a more detailed view of the platform-specific image manifests
    /// <br/>or other image-attached data like build attestations.
    /// <br/>
    /// <br/>WARNING: This is experimental and may change at any time without any backward
    /// <br/>compatibility.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Manifests")]
    public ICollection<ImageManifestSummary>? Manifests { get; set; } = default!;

    /// <summary>
    /// Descriptor is an OCI descriptor of the image target.
    /// <br/>In case of a multi-platform image, this descriptor points to the OCI index
    /// <br/>or a manifest list.
    /// <br/>
    /// <br/>This field is only present if the daemon provides a multi-platform image store.
    /// <br/>
    /// <br/>WARNING: This is experimental and may change at any time without any backward
    /// <br/>compatibility.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Descriptor")]
    public OCIDescriptor? Descriptor { get; set; } = default!;


}