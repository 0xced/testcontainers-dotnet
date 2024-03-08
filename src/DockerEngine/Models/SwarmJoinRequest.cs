using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SwarmJoinRequest
{
    /// <summary>
    /// Listen address used for inter-manager communication if the node
    /// <br/>gets promoted to manager, as well as determining the networking
    /// <br/>interface used for the VXLAN Tunnel Endpoint (VTEP).
    /// <br/>
    /// </summary>

    [JsonPropertyName("ListenAddr")]
    public string? ListenAddr { get; set; } = default!;

    /// <summary>
    /// Externally reachable address advertised to other nodes. This
    /// <br/>can either be an address/port combination in the form
    /// <br/>`192.168.1.1:4567`, or an interface followed by a port number,
    /// <br/>like `eth0:4567`. If the port number is omitted, the port
    /// <br/>number from the listen address is used. If `AdvertiseAddr` is
    /// <br/>not specified, it will be automatically detected when possible.
    /// <br/>
    /// </summary>

    [JsonPropertyName("AdvertiseAddr")]
    public string? AdvertiseAddr { get; set; } = default!;

    /// <summary>
    /// Address or interface to use for data path traffic (format:
    /// <br/>`&lt;ip|interface&gt;`), for example,  `192.168.1.1`, or an interface,
    /// <br/>like `eth0`. If `DataPathAddr` is unspecified, the same address
    /// <br/>as `AdvertiseAddr` is used.
    /// <br/>
    /// <br/>The `DataPathAddr` specifies the address that global scope
    /// <br/>network drivers will publish towards other nodes in order to
    /// <br/>reach the containers running on this node. Using this parameter
    /// <br/>it is possible to separate the container data traffic from the
    /// <br/>management traffic of the cluster.
    /// <br/>
    /// </summary>

    [JsonPropertyName("DataPathAddr")]
    public string? DataPathAddr { get; set; } = default!;

    /// <summary>
    /// Addresses of manager nodes already participating in the swarm.
    /// <br/>
    /// </summary>

    [JsonPropertyName("RemoteAddrs")]
    public System.Collections.Generic.ICollection<string>? RemoteAddrs { get; set; } = default!;

    /// <summary>
    /// Secret token for joining this swarm.
    /// </summary>

    [JsonPropertyName("JoinToken")]
    public string? JoinToken { get; set; } = default!;


}