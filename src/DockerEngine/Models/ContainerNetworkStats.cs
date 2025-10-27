namespace DockerEngine;

/// <summary>
/// Aggregates the network stats of one container
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerNetworkStats
{
    /// <summary>
    /// Bytes received. Windows and Linux.
    /// <br/>
    /// </summary>

    [JsonPropertyName("rx_bytes")]
    public ulong? Rx_bytes { get; set; } = default!;

    /// <summary>
    /// Packets received. Windows and Linux.
    /// <br/>
    /// </summary>

    [JsonPropertyName("rx_packets")]
    public ulong? Rx_packets { get; set; } = default!;

    /// <summary>
    /// Received errors. Not used on Windows.
    /// <br/>
    /// <br/>This field is Linux-specific and always zero for Windows containers.
    /// <br/>
    /// </summary>

    [JsonPropertyName("rx_errors")]
    public ulong? Rx_errors { get; set; } = default!;

    /// <summary>
    /// Incoming packets dropped. Windows and Linux.
    /// <br/>
    /// </summary>

    [JsonPropertyName("rx_dropped")]
    public ulong? Rx_dropped { get; set; } = default!;

    /// <summary>
    /// Bytes sent. Windows and Linux.
    /// <br/>
    /// </summary>

    [JsonPropertyName("tx_bytes")]
    public ulong? Tx_bytes { get; set; } = default!;

    /// <summary>
    /// Packets sent. Windows and Linux.
    /// <br/>
    /// </summary>

    [JsonPropertyName("tx_packets")]
    public ulong? Tx_packets { get; set; } = default!;

    /// <summary>
    /// Sent errors. Not used on Windows.
    /// <br/>
    /// <br/>This field is Linux-specific and always zero for Windows containers.
    /// <br/>
    /// </summary>

    [JsonPropertyName("tx_errors")]
    public ulong? Tx_errors { get; set; } = default!;

    /// <summary>
    /// Outgoing packets dropped. Windows and Linux.
    /// <br/>
    /// </summary>

    [JsonPropertyName("tx_dropped")]
    public ulong? Tx_dropped { get; set; } = default!;

    /// <summary>
    /// Endpoint ID. Not used on Linux.
    /// <br/>
    /// <br/>This field is Windows-specific and omitted for Linux containers.
    /// <br/>
    /// </summary>

    [JsonPropertyName("endpoint_id")]
    public string? Endpoint_id { get; set; } = default!;

    /// <summary>
    /// Instance ID. Not used on Linux.
    /// <br/>
    /// <br/>This field is Windows-specific and omitted for Linux containers.
    /// <br/>
    /// </summary>

    [JsonPropertyName("instance_id")]
    public string? Instance_id { get; set; } = default!;


}