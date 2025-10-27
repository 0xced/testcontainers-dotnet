namespace DockerEngine;

/// <summary>
/// Information about an image in the local image cache.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class ImageInspect
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
    public string? Id { get; set; } = default!;

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

    /// <summary>
    /// Manifests is a list of image manifests available in this image. It
    /// <br/>provides a more detailed view of the platform-specific image manifests or
    /// <br/>other image-attached data like build attestations.
    /// <br/>
    /// <br/>Only available if the daemon provides a multi-platform image store
    /// <br/>and the `manifests` option is set in the inspect request.
    /// <br/>
    /// <br/>WARNING: This is experimental and may change at any time without any backward
    /// <br/>compatibility.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Manifests")]
    public ICollection<ImageManifestSummary>? Manifests { get; set; } = default!;

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
    public ICollection<string>? RepoTags { get; set; } = default!;

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
    public ICollection<string>? RepoDigests { get; set; } = default!;

    /// <summary>
    /// ID of the parent image.
    /// <br/>
    /// <br/>Depending on how the image was created, this field may be empty and
    /// <br/>is only set for images that were built/created locally. This field
    /// <br/>is empty if the image was pulled from an image registry.
    /// <br/>
    /// <br/>&gt; **Deprecated**: This field is only set when using the deprecated
    /// <br/>&gt; legacy builder. It is included in API responses for informational
    /// <br/>&gt; purposes, but should not be depended on as it will be omitted
    /// <br/>&gt; once the legacy builder is removed.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Parent")]
    public string? Parent { get; set; } = default!;

    /// <summary>
    /// Optional message that was set when committing or importing the image.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Comment")]
    public string? Comment { get; set; } = default!;

    /// <summary>
    /// Date and time at which the image was created, formatted in
    /// <br/>[RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) format with nano-seconds.
    /// <br/>
    /// <br/>This information is only available if present in the image,
    /// <br/>and omitted otherwise.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Created")]
    public string? Created { get; set; } = default!;

    /// <summary>
    /// The version of Docker that was used to build the image.
    /// <br/>
    /// <br/>Depending on how the image was created, this field may be empty.
    /// <br/>
    /// <br/>&gt; **Deprecated**: This field is only set when using the deprecated
    /// <br/>&gt; legacy builder. It is included in API responses for informational
    /// <br/>&gt; purposes, but should not be depended on as it will be omitted
    /// <br/>&gt; once the legacy builder is removed.
    /// <br/>
    /// </summary>

    [JsonPropertyName("DockerVersion")]
    public string? DockerVersion { get; set; } = default!;

    /// <summary>
    /// Name of the author that was specified when committing the image, or as
    /// <br/>specified through MAINTAINER (deprecated) in the Dockerfile.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Author")]
    public string? Author { get; set; } = default!;


    [JsonPropertyName("Config")]
    public ImageConfig? Config { get; set; } = default!;

    /// <summary>
    /// Hardware CPU architecture that the image runs on.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Architecture")]
    public string? Architecture { get; set; } = default!;

    /// <summary>
    /// CPU architecture variant (presently ARM-only).
    /// <br/>
    /// </summary>

    [JsonPropertyName("Variant")]
    public string? Variant { get; set; } = default!;

    /// <summary>
    /// Operating System the image is built to run on.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Os")]
    public string? Os { get; set; } = default!;

    /// <summary>
    /// Operating System version the image is built to run on (especially
    /// <br/>for Windows).
    /// <br/>
    /// </summary>

    [JsonPropertyName("OsVersion")]
    public string? OsVersion { get; set; } = default!;

    /// <summary>
    /// Total size of the image including all layers it is composed of.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Size")]
    public long? Size { get; set; } = default!;


    [JsonPropertyName("GraphDriver")]
    public DriverData? GraphDriver { get; set; } = default!;

    /// <summary>
    /// Information about the image's RootFS, including the layer IDs.
    /// <br/>
    /// </summary>

    [JsonPropertyName("RootFS")]
    public RootFS? RootFS { get; set; } = default!;

    /// <summary>
    /// Additional metadata of the image in the local cache. This information
    /// <br/>is local to the daemon, and not part of the image itself.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Metadata")]
    public Metadata? Metadata { get; set; } = default!;


}