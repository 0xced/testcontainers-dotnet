using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// NetworkingConfig represents the container's networking configuration for
/// <br/>each of its interfaces.
/// <br/>It is used for the networking configs specified in the `docker create`
/// <br/>and `docker network connect` commands.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class NetworkingConfig
{
    /// <summary>
    /// A mapping of network name to endpoint configuration for that network.
    /// <br/>The endpoint configuration can be left empty to connect to that
    /// <br/>network with no particular endpoint configuration.
    /// <br/>
    /// </summary>

    [JsonPropertyName("EndpointsConfig")]
    public System.Collections.Generic.IDictionary<string, EndpointSettings>? EndpointsConfig { get; set; } = default!;


}