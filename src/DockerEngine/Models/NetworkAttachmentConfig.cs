using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Specifies how a service should be attached to a particular network.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class NetworkAttachmentConfig
{
    /// <summary>
    /// The target network for attachment. Must be a network name or ID.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Target")]
    public string? Target { get; set; } = default!;

    /// <summary>
    /// Discoverable alternate names for the service on this network.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Aliases")]
    public ICollection<string>? Aliases { get; set; } = default!;

    /// <summary>
    /// Driver attachment options for the network target.
    /// <br/>
    /// </summary>

    [JsonPropertyName("DriverOpts")]
    public IDictionary<string, string>? DriverOpts { get; set; } = default!;


}