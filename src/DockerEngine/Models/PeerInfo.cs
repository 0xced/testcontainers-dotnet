namespace DockerEngine;

/// <summary>
/// PeerInfo represents one peer of an overlay network.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class PeerInfo
{
    /// <summary>
    /// ID of the peer-node in the Swarm cluster.
    /// </summary>

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;

    /// <summary>
    /// IP-address of the peer-node in the Swarm cluster.
    /// </summary>

    [JsonPropertyName("IP")]
    public string? IP { get; set; } = default!;


}