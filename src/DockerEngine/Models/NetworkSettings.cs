using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// NetworkSettings exposes the network settings in the API
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class NetworkSettings
{
    /// <summary>
    /// Name of the default bridge interface when dockerd's --bridge flag is set.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Bridge")]
    public string? Bridge { get; set; } = default!;

    /// <summary>
    /// SandboxID uniquely represents a container's network stack.
    /// </summary>

    [JsonPropertyName("SandboxID")]
    public string? SandboxID { get; set; } = default!;

    /// <summary>
    /// Indicates if hairpin NAT should be enabled on the virtual interface.
    /// <br/>
    /// <br/>Deprecated: This field is never set and will be removed in a future release.
    /// <br/>
    /// </summary>

    [JsonPropertyName("HairpinMode")]
    public bool? HairpinMode { get; set; } = default!;

    /// <summary>
    /// IPv6 unicast address using the link-local prefix.
    /// <br/>
    /// <br/>Deprecated: This field is never set and will be removed in a future release.
    /// <br/>
    /// </summary>

    [JsonPropertyName("LinkLocalIPv6Address")]
    public string? LinkLocalIPv6Address { get; set; } = default!;

    /// <summary>
    /// Prefix length of the IPv6 unicast address.
    /// <br/>
    /// <br/>Deprecated: This field is never set and will be removed in a future release.
    /// <br/>
    /// </summary>

    [JsonPropertyName("LinkLocalIPv6PrefixLen")]
    public int? LinkLocalIPv6PrefixLen { get; set; } = default!;


    [JsonPropertyName("Ports")]
    public PortMap? Ports { get; set; } = default!;

    /// <summary>
    /// SandboxKey is the full path of the netns handle
    /// </summary>

    [JsonPropertyName("SandboxKey")]
    public string? SandboxKey { get; set; } = default!;

    /// <summary>
    /// Deprecated: This field is never set and will be removed in a future release.
    /// </summary>

    [JsonPropertyName("SecondaryIPAddresses")]
    public System.Collections.Generic.ICollection<Address>? SecondaryIPAddresses { get; set; } = default!;

    /// <summary>
    /// Deprecated: This field is never set and will be removed in a future release.
    /// </summary>

    [JsonPropertyName("SecondaryIPv6Addresses")]
    public System.Collections.Generic.ICollection<Address>? SecondaryIPv6Addresses { get; set; } = default!;

    /// <summary>
    /// EndpointID uniquely represents a service endpoint in a Sandbox.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Deprecated**: This field is only propagated when attached to the
    /// <br/>&gt; default "bridge" network. Use the information from the "bridge"
    /// <br/>&gt; network inside the `Networks` map instead, which contains the same
    /// <br/>&gt; information. This field was deprecated in Docker 1.9 and is scheduled
    /// <br/>&gt; to be removed in Docker 17.12.0
    /// <br/>
    /// </summary>

    [JsonPropertyName("EndpointID")]
    public string? EndpointID { get; set; } = default!;

    /// <summary>
    /// Gateway address for the default "bridge" network.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Deprecated**: This field is only propagated when attached to the
    /// <br/>&gt; default "bridge" network. Use the information from the "bridge"
    /// <br/>&gt; network inside the `Networks` map instead, which contains the same
    /// <br/>&gt; information. This field was deprecated in Docker 1.9 and is scheduled
    /// <br/>&gt; to be removed in Docker 17.12.0
    /// <br/>
    /// </summary>

    [JsonPropertyName("Gateway")]
    public string? Gateway { get; set; } = default!;

    /// <summary>
    /// Global IPv6 address for the default "bridge" network.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Deprecated**: This field is only propagated when attached to the
    /// <br/>&gt; default "bridge" network. Use the information from the "bridge"
    /// <br/>&gt; network inside the `Networks` map instead, which contains the same
    /// <br/>&gt; information. This field was deprecated in Docker 1.9 and is scheduled
    /// <br/>&gt; to be removed in Docker 17.12.0
    /// <br/>
    /// </summary>

    [JsonPropertyName("GlobalIPv6Address")]
    public string? GlobalIPv6Address { get; set; } = default!;

    /// <summary>
    /// Mask length of the global IPv6 address.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Deprecated**: This field is only propagated when attached to the
    /// <br/>&gt; default "bridge" network. Use the information from the "bridge"
    /// <br/>&gt; network inside the `Networks` map instead, which contains the same
    /// <br/>&gt; information. This field was deprecated in Docker 1.9 and is scheduled
    /// <br/>&gt; to be removed in Docker 17.12.0
    /// <br/>
    /// </summary>

    [JsonPropertyName("GlobalIPv6PrefixLen")]
    public int? GlobalIPv6PrefixLen { get; set; } = default!;

    /// <summary>
    /// IPv4 address for the default "bridge" network.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Deprecated**: This field is only propagated when attached to the
    /// <br/>&gt; default "bridge" network. Use the information from the "bridge"
    /// <br/>&gt; network inside the `Networks` map instead, which contains the same
    /// <br/>&gt; information. This field was deprecated in Docker 1.9 and is scheduled
    /// <br/>&gt; to be removed in Docker 17.12.0
    /// <br/>
    /// </summary>

    [JsonPropertyName("IPAddress")]
    public string? IPAddress { get; set; } = default!;

    /// <summary>
    /// Mask length of the IPv4 address.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Deprecated**: This field is only propagated when attached to the
    /// <br/>&gt; default "bridge" network. Use the information from the "bridge"
    /// <br/>&gt; network inside the `Networks` map instead, which contains the same
    /// <br/>&gt; information. This field was deprecated in Docker 1.9 and is scheduled
    /// <br/>&gt; to be removed in Docker 17.12.0
    /// <br/>
    /// </summary>

    [JsonPropertyName("IPPrefixLen")]
    public int? IPPrefixLen { get; set; } = default!;

    /// <summary>
    /// IPv6 gateway address for this network.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Deprecated**: This field is only propagated when attached to the
    /// <br/>&gt; default "bridge" network. Use the information from the "bridge"
    /// <br/>&gt; network inside the `Networks` map instead, which contains the same
    /// <br/>&gt; information. This field was deprecated in Docker 1.9 and is scheduled
    /// <br/>&gt; to be removed in Docker 17.12.0
    /// <br/>
    /// </summary>

    [JsonPropertyName("IPv6Gateway")]
    public string? IPv6Gateway { get; set; } = default!;

    /// <summary>
    /// MAC address for the container on the default "bridge" network.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Deprecated**: This field is only propagated when attached to the
    /// <br/>&gt; default "bridge" network. Use the information from the "bridge"
    /// <br/>&gt; network inside the `Networks` map instead, which contains the same
    /// <br/>&gt; information. This field was deprecated in Docker 1.9 and is scheduled
    /// <br/>&gt; to be removed in Docker 17.12.0
    /// <br/>
    /// </summary>

    [JsonPropertyName("MacAddress")]
    public string? MacAddress { get; set; } = default!;

    /// <summary>
    /// Information about all networks that the container is connected to.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Networks")]
    public System.Collections.Generic.IDictionary<string, EndpointSettings>? Networks { get; set; } = default!;


}