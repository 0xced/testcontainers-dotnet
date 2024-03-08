using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class NetworkDisconnectRequest
{
    /// <summary>
    /// The ID or name of the container to disconnect from the network.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Container")]
    public string? Container { get; set; } = default!;

    /// <summary>
    /// Force the container to disconnect from the network.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Force")]
    public bool? Force { get; set; } = default!;


}