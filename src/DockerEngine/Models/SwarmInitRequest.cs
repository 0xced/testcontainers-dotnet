using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SwarmInitRequest
{
    /// <summary>
    /// Listen address used for inter-manager communication, as well
    /// <br/>as determining the networking interface used for the VXLAN
    /// <br/>Tunnel Endpoint (VTEP). This can either be an address/port
    /// <br/>combination in the form `192.168.1.1:4567`, or an interface
    /// <br/>followed by a port number, like `eth0:4567`. If the port number
    /// <br/>is omitted, the default swarm listening port is used.
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
    /// <br/>network drivers will publish towards other  nodes in order to
    /// <br/>reach the containers running on this node. Using this parameter
    /// <br/>it is possible to separate the container data traffic from the
    /// <br/>management traffic of the cluster.
    /// <br/>
    /// </summary>

    [JsonPropertyName("DataPathAddr")]
    public string? DataPathAddr { get; set; } = default!;

    /// <summary>
    /// DataPathPort specifies the data path port number for data traffic.
    /// <br/>Acceptable port range is 1024 to 49151.
    /// <br/>if no port is set or is set to 0, default port 4789 will be used.
    /// <br/>
    /// </summary>

    [JsonPropertyName("DataPathPort")]
    public int? DataPathPort { get; set; } = default!;

    /// <summary>
    /// Default Address Pool specifies default subnet pools for global
    /// <br/>scope networks.
    /// <br/>
    /// </summary>

    [JsonPropertyName("DefaultAddrPool")]
    public ICollection<string>? DefaultAddrPool { get; set; } = default!;

    /// <summary>
    /// Force creation of a new swarm.
    /// </summary>

    [JsonPropertyName("ForceNewCluster")]
    public bool? ForceNewCluster { get; set; } = default!;

    /// <summary>
    /// SubnetSize specifies the subnet size of the networks created
    /// <br/>from the default subnet pool.
    /// <br/>
    /// </summary>

    [JsonPropertyName("SubnetSize")]
    public int? SubnetSize { get; set; } = default!;


    [JsonPropertyName("Spec")]
    public SwarmSpec? Spec { get; set; } = default!;


}