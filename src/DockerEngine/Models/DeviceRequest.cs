using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// A request for devices to be sent to device drivers
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DeviceRequest
{

    [JsonPropertyName("Driver")]
    public string? Driver { get; set; } = default!;


    [JsonPropertyName("Count")]
    public int? Count { get; set; } = default!;


    [JsonPropertyName("DeviceIDs")]
    public ICollection<string>? DeviceIDs { get; set; } = default!;

    /// <summary>
    /// A list of capabilities; an OR list of AND lists of capabilities.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Capabilities")]
    public ICollection<ICollection<string>>? Capabilities { get; set; } = default!;

    /// <summary>
    /// Driver-specific options, specified as a key/value pairs. These options
    /// <br/>are passed directly to the driver.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Options")]
    public IDictionary<string, string>? Options { get; set; } = default!;


}