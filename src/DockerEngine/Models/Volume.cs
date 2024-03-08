using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Volume
{
    /// <summary>
    /// Name of the volume.
    /// </summary>

    [JsonPropertyName("Name")]
    public string Name { get; set; } = default!;

    /// <summary>
    /// Name of the volume driver used by the volume.
    /// </summary>

    [JsonPropertyName("Driver")]
    public string Driver { get; set; } = default!;

    /// <summary>
    /// Mount path of the volume on the host.
    /// </summary>

    [JsonPropertyName("Mountpoint")]
    public string Mountpoint { get; set; } = default!;

    /// <summary>
    /// Date/Time the volume was created.
    /// </summary>

    [JsonPropertyName("CreatedAt")]
    public string? CreatedAt { get; set; } = default!;

    /// <summary>
    /// Low-level details about the volume, provided by the volume driver.
    /// <br/>Details are returned as a map with key/value pairs:
    /// <br/>`{"key":"value","key2":"value2"}`.
    /// <br/>
    /// <br/>The `Status` field is optional, and is omitted if the volume driver
    /// <br/>does not support this feature.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Status")]
    public IDictionary<string, object>? Status { get; set; } = default!;

    /// <summary>
    /// User-defined key/value metadata.
    /// </summary>

    [JsonPropertyName("Labels")]
    public IDictionary<string, string> Labels { get; set; } = new Dictionary<string, string>();

    /// <summary>
    /// The level at which the volume exists. Either `global` for cluster-wide,
    /// <br/>or `local` for machine level.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Scope")]
    [JsonConverter(typeof(JsonEnumMemberConverter<VolumeScope>))]
    public VolumeScope Scope { get; set; } = DockerEngine.VolumeScope.Local;


    [JsonPropertyName("ClusterVolume")]
    public ClusterVolume? ClusterVolume { get; set; } = default!;

    /// <summary>
    /// The driver specific options used when creating the volume.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Options")]
    public IDictionary<string, string> Options { get; set; } = new Dictionary<string, string>();

    /// <summary>
    /// Usage details about the volume. This information is used by the
    /// <br/>`GET /system/df` endpoint, and omitted in other endpoints.
    /// <br/>
    /// </summary>

    [JsonPropertyName("UsageData")]
    public UsageData? UsageData { get; set; } = default!;


}