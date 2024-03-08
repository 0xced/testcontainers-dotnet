using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Volume configuration
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class VolumeCreateOptions
{
    /// <summary>
    /// The new volume's name. If not specified, Docker generates a name.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;

    /// <summary>
    /// Name of the volume driver to use.
    /// </summary>

    [JsonPropertyName("Driver")]
    public string? Driver { get; set; } = "local";

    /// <summary>
    /// A mapping of driver options and values. These options are
    /// <br/>passed directly to the driver and are driver specific.
    /// <br/>
    /// </summary>

    [JsonPropertyName("DriverOpts")]
    public IDictionary<string, string>? DriverOpts { get; set; } = default!;

    /// <summary>
    /// User-defined key/value metadata.
    /// </summary>

    [JsonPropertyName("Labels")]
    public IDictionary<string, string>? Labels { get; set; } = default!;


    [JsonPropertyName("ClusterVolumeSpec")]
    public ClusterVolumeSpec? ClusterVolumeSpec { get; set; } = default!;


}