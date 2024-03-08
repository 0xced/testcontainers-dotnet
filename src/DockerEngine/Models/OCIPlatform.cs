using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Describes the platform which the image in the manifest runs on, as defined
/// <br/>in the [OCI Image Index Specification](https://github.com/opencontainers/image-spec/blob/v1.0.1/image-index.md).
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OCIPlatform
{
    /// <summary>
    /// The CPU architecture, for example `amd64` or `ppc64`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; } = default!;

    /// <summary>
    /// The operating system, for example `linux` or `windows`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("os")]
    public string? Os { get; set; } = default!;

    /// <summary>
    /// Optional field specifying the operating system version, for example on
    /// <br/>Windows `10.0.19041.1165`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("os.version")]
    public string? OsVersion { get; set; } = default!;

    /// <summary>
    /// Optional field specifying an array of strings, each listing a required
    /// <br/>OS feature (for example on Windows `win32k`).
    /// <br/>
    /// </summary>

    [JsonPropertyName("os.features")]
    public ICollection<string>? OsFeatures { get; set; } = default!;

    /// <summary>
    /// Optional field specifying a variant of the CPU, for example `v7` to
    /// <br/>specify ARMv7 when architecture is `arm`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("variant")]
    public string? Variant { get; set; } = default!;


}