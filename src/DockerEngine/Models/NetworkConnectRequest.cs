using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class NetworkConnectRequest
{
    /// <summary>
    /// The ID or name of the container to connect to the network.
    /// </summary>

    [JsonPropertyName("Container")]
    public string? Container { get; set; } = default!;


    [JsonPropertyName("EndpointConfig")]
    public EndpointSettings? EndpointConfig { get; set; } = default!;


}