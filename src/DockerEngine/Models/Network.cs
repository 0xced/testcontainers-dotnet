namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class Network
{
    /// <summary>
    /// Name of the network.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;

    /// <summary>
    /// ID that uniquely identifies a network on a single machine.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Id")]
    public string? Id { get; set; } = default!;

    /// <summary>
    /// Date and time at which the network was created in
    /// <br/>[RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) format with nano-seconds.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Created")]
    public string? Created { get; set; } = default!;

    /// <summary>
    /// The level at which the network exists (e.g. `swarm` for cluster-wide
    /// <br/>or `local` for machine level)
    /// <br/>
    /// </summary>

    [JsonPropertyName("Scope")]
    public string? Scope { get; set; } = default!;

    /// <summary>
    /// The name of the driver used to create the network (e.g. `bridge`,
    /// <br/>`overlay`).
    /// <br/>
    /// </summary>

    [JsonPropertyName("Driver")]
    public string? Driver { get; set; } = default!;

    /// <summary>
    /// Whether the network was created with IPv4 enabled.
    /// <br/>
    /// </summary>

    [JsonPropertyName("EnableIPv4")]
    public bool? EnableIPv4 { get; set; } = default!;

    /// <summary>
    /// Whether the network was created with IPv6 enabled.
    /// <br/>
    /// </summary>

    [JsonPropertyName("EnableIPv6")]
    public bool? EnableIPv6 { get; set; } = default!;


    [JsonPropertyName("IPAM")]
    public IPAM? IPAM { get; set; } = default!;

    /// <summary>
    /// Whether the network is created to only allow internal networking
    /// <br/>connectivity.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Internal")]
    public bool? Internal { get; set; } = false;

    /// <summary>
    /// Whether a global / swarm scope network is manually attachable by regular
    /// <br/>containers from workers in swarm mode.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Attachable")]
    public bool? Attachable { get; set; } = false;

    /// <summary>
    /// Whether the network is providing the routing-mesh for the swarm cluster.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Ingress")]
    public bool? Ingress { get; set; } = false;


    [JsonPropertyName("ConfigFrom")]
    public ConfigReference? ConfigFrom { get; set; } = default!;

    /// <summary>
    /// Whether the network is a config-only network. Config-only networks are
    /// <br/>placeholder networks for network configurations to be used by other
    /// <br/>networks. Config-only networks cannot be used directly to run containers
    /// <br/>or services.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ConfigOnly")]
    public bool? ConfigOnly { get; set; } = false;

    /// <summary>
    /// Contains endpoints attached to the network.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Containers")]
    public IDictionary<string, NetworkContainer>? Containers { get; set; } = default!;

    /// <summary>
    /// Network-specific options uses when creating the network.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Options")]
    public IDictionary<string, string>? Options { get; set; } = default!;

    /// <summary>
    /// User-defined key/value metadata.
    /// </summary>

    [JsonPropertyName("Labels")]
    public IDictionary<string, string>? Labels { get; set; } = default!;

    /// <summary>
    /// List of peer nodes for an overlay network. This field is only present
    /// <br/>for overlay networks, and omitted for other network types.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Peers")]
    public ICollection<PeerInfo>? Peers { get; set; } = default!;


}