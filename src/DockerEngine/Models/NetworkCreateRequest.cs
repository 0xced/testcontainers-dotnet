namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class NetworkCreateRequest
{
    /// <summary>
    /// The network's name.
    /// </summary>

    [JsonPropertyName("Name")]
    public string Name { get; set; } = default!;

    /// <summary>
    /// Deprecated: CheckDuplicate is now always enabled.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CheckDuplicate")]
    public bool? CheckDuplicate { get; set; } = default!;

    /// <summary>
    /// Name of the network driver plugin to use.
    /// </summary>

    [JsonPropertyName("Driver")]
    public string? Driver { get; set; } = "bridge";

    /// <summary>
    /// The level at which the network exists (e.g. `swarm` for cluster-wide
    /// <br/>or `local` for machine level).
    /// <br/>
    /// </summary>

    [JsonPropertyName("Scope")]
    public string? Scope { get; set; } = default!;

    /// <summary>
    /// Restrict external access to the network.
    /// </summary>

    [JsonPropertyName("Internal")]
    public bool? Internal { get; set; } = default!;

    /// <summary>
    /// Globally scoped network is manually attachable by regular
    /// <br/>containers from workers in swarm mode.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Attachable")]
    public bool? Attachable { get; set; } = default!;

    /// <summary>
    /// Ingress network is the network which provides the routing-mesh
    /// <br/>in swarm mode.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Ingress")]
    public bool? Ingress { get; set; } = default!;

    /// <summary>
    /// Creates a config-only network. Config-only networks are placeholder
    /// <br/>networks for network configurations to be used by other networks.
    /// <br/>Config-only networks cannot be used directly to run containers
    /// <br/>or services.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ConfigOnly")]
    public bool? ConfigOnly { get; set; } = false;

    /// <summary>
    /// Specifies the source which will provide the configuration for
    /// <br/>this network. The specified network must be an existing
    /// <br/>config-only network; see ConfigOnly.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ConfigFrom")]
    public ConfigReference? ConfigFrom { get; set; } = default!;

    /// <summary>
    /// Optional custom IP scheme for the network.
    /// </summary>

    [JsonPropertyName("IPAM")]
    public IPAM? IPAM { get; set; } = default!;

    /// <summary>
    /// Enable IPv6 on the network.
    /// </summary>

    [JsonPropertyName("EnableIPv6")]
    public bool? EnableIPv6 { get; set; } = default!;

    /// <summary>
    /// Network specific options to be used by the drivers.
    /// </summary>

    [JsonPropertyName("Options")]
    public IDictionary<string, string>? Options { get; set; } = default!;

    /// <summary>
    /// User-defined key/value metadata.
    /// </summary>

    [JsonPropertyName("Labels")]
    public IDictionary<string, string>? Labels { get; set; } = default!;


}