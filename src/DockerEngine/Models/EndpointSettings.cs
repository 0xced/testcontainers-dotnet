using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Configuration for a network endpoint.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EndpointSettings
{

    [JsonPropertyName("IPAMConfig")]
    public EndpointIPAMConfig? IPAMConfig { get; set; } = default!;


    [JsonPropertyName("Links")]
    public ICollection<string>? Links { get; set; } = default!;

    /// <summary>
    /// MAC address for the endpoint on this network. The network driver might ignore this parameter.
    /// <br/>
    /// </summary>

    [JsonPropertyName("MacAddress")]
    public string? MacAddress { get; set; } = default!;


    [JsonPropertyName("Aliases")]
    public ICollection<string>? Aliases { get; set; } = default!;

    /// <summary>
    /// Unique ID of the network.
    /// <br/>
    /// </summary>

    [JsonPropertyName("NetworkID")]
    public string? NetworkID { get; set; } = default!;

    /// <summary>
    /// Unique ID for the service endpoint in a Sandbox.
    /// <br/>
    /// </summary>

    [JsonPropertyName("EndpointID")]
    public string? EndpointID { get; set; } = default!;

    /// <summary>
    /// Gateway address for this network.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Gateway")]
    public string? Gateway { get; set; } = default!;

    /// <summary>
    /// IPv4 address.
    /// <br/>
    /// </summary>

    [JsonPropertyName("IPAddress")]
    public string? IPAddress { get; set; } = default!;

    /// <summary>
    /// Mask length of the IPv4 address.
    /// <br/>
    /// </summary>

    [JsonPropertyName("IPPrefixLen")]
    public int? IPPrefixLen { get; set; } = default!;

    /// <summary>
    /// IPv6 gateway address.
    /// <br/>
    /// </summary>

    [JsonPropertyName("IPv6Gateway")]
    public string? IPv6Gateway { get; set; } = default!;

    /// <summary>
    /// Global IPv6 address.
    /// <br/>
    /// </summary>

    [JsonPropertyName("GlobalIPv6Address")]
    public string? GlobalIPv6Address { get; set; } = default!;

    /// <summary>
    /// Mask length of the global IPv6 address.
    /// <br/>
    /// </summary>

    [JsonPropertyName("GlobalIPv6PrefixLen")]
    public long? GlobalIPv6PrefixLen { get; set; } = default!;

    /// <summary>
    /// DriverOpts is a mapping of driver options and values. These options
    /// <br/>are passed directly to the driver and are driver specific.
    /// <br/>
    /// </summary>

    [JsonPropertyName("DriverOpts")]
    public IDictionary<string, string>? DriverOpts { get; set; } = default!;

    /// <summary>
    /// List of all DNS names an endpoint has on a specific network. This
    /// <br/>list is based on the container name, network aliases, container short
    /// <br/>ID, and hostname.
    /// <br/>
    /// <br/>These DNS names are non-fully qualified but can contain several dots.
    /// <br/>You can get fully qualified DNS names by appending `.&lt;network-name&gt;`.
    /// <br/>For instance, if container name is `my.ctr` and the network is named
    /// <br/>`testnet`, `DNSNames` will contain `my.ctr` and the FQDN will be
    /// <br/>`my.ctr.testnet`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("DNSNames")]
    public ICollection<string>? DNSNames { get; set; } = default!;


}