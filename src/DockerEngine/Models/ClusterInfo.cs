using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// ClusterInfo represents information about the swarm as is returned by the
/// <br/>"/info" endpoint. Join-tokens are not included.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ClusterInfo
{
    /// <summary>
    /// The ID of the swarm.
    /// </summary>

    [JsonPropertyName("ID")]
    public string? ID { get; set; } = default!;


    [JsonPropertyName("Version")]
    public ObjectVersion? Version { get; set; } = default!;

    /// <summary>
    /// Date and time at which the swarm was initialised in
    /// <br/>[RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) format with nano-seconds.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CreatedAt")]
    public string? CreatedAt { get; set; } = default!;

    /// <summary>
    /// Date and time at which the swarm was last updated in
    /// <br/>[RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) format with nano-seconds.
    /// <br/>
    /// </summary>

    [JsonPropertyName("UpdatedAt")]
    public string? UpdatedAt { get; set; } = default!;


    [JsonPropertyName("Spec")]
    public SwarmSpec? Spec { get; set; } = default!;


    [JsonPropertyName("TLSInfo")]
    public TLSInfo? TLSInfo { get; set; } = default!;

    /// <summary>
    /// Whether there is currently a root CA rotation in progress for the swarm
    /// <br/>
    /// </summary>

    [JsonPropertyName("RootRotationInProgress")]
    public bool? RootRotationInProgress { get; set; } = default!;

    /// <summary>
    /// DataPathPort specifies the data path port number for data traffic.
    /// <br/>Acceptable port range is 1024 to 49151.
    /// <br/>If no port is set or is set to 0, the default port (4789) is used.
    /// <br/>
    /// </summary>

    [JsonPropertyName("DataPathPort")]
    public int? DataPathPort { get; set; } = 4789;

    /// <summary>
    /// Default Address Pool specifies default subnet pools for global scope
    /// <br/>networks.
    /// <br/>
    /// </summary>

    [JsonPropertyName("DefaultAddrPool")]
    public System.Collections.Generic.ICollection<string>? DefaultAddrPool { get; set; } = default!;

    /// <summary>
    /// SubnetSize specifies the subnet size of the networks created from the
    /// <br/>default subnet pool.
    /// <br/>
    /// </summary>

    [JsonPropertyName("SubnetSize")]
    public int? SubnetSize { get; set; } = 24;


}