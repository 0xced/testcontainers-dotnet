using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Information about an image in the local image cache.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
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
    /// The ID of the container that was used to create the image.
    /// <br/>
    /// <br/>Depending on how the image was created, this field may be empty.
    /// <br/>
    /// <br/>**Deprecated**: this field is kept for backward compatibility, but
    /// <br/>will be removed in API v1.45.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Container")]
    public string? Container { get; set; } = default!;

    /// <summary>
    /// **Deprecated**: this field is kept for backward compatibility, but
    /// <br/>will be removed in API v1.45.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ContainerConfig")]
    public ContainerConfig? ContainerConfig { get; set; } = default!;

    /// <summary>
    /// The version of Docker that was used to build the image.
    /// <br/>
    /// <br/>Depending on how the image was created, this field may be empty.
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
    public ContainerConfig? Config { get; set; } = default!;

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

    /// <summary>
    /// Total size of the image including all layers it is composed of.
    /// <br/>
    /// <br/>Deprecated: this field is omitted in API v1.44, but kept for backward compatibility. Use Size instead.
    /// <br/>
    /// </summary>

    [JsonPropertyName("VirtualSize")]
    public long? VirtualSize { get; set; } = default!;


    [JsonPropertyName("GraphDriver")]
    public GraphDriverData? GraphDriver { get; set; } = default!;

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