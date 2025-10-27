namespace DockerEngine;

/// <summary>
/// Statistics sample for a container.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerStatsResponse
{
    /// <summary>
    /// Name of the container
    /// </summary>

    [JsonPropertyName("name")]
    public string? Name { get; set; } = default!;

    /// <summary>
    /// ID of the container
    /// </summary>

    [JsonPropertyName("id")]
    public string? Id { get; set; } = default!;

    /// <summary>
    /// Date and time at which this sample was collected.
    /// <br/>The value is formatted as [RFC 3339](https://www.ietf.org/rfc/rfc3339.txt)
    /// <br/>with nano-seconds.
    /// <br/>
    /// </summary>

    [JsonPropertyName("read")]
    public DateTimeOffset? Read { get; set; } = default!;

    /// <summary>
    /// Date and time at which this first sample was collected. This field
    /// <br/>is not propagated if the "one-shot" option is set. If the "one-shot"
    /// <br/>option is set, this field may be omitted, empty, or set to a default
    /// <br/>date (`0001-01-01T00:00:00Z`).
    /// <br/>
    /// <br/>The value is formatted as [RFC 3339](https://www.ietf.org/rfc/rfc3339.txt)
    /// <br/>with nano-seconds.
    /// <br/>
    /// </summary>

    [JsonPropertyName("preread")]
    public DateTimeOffset? Preread { get; set; } = default!;


    [JsonPropertyName("pids_stats")]
    public ContainerPidsStats? Pids_stats { get; set; } = default!;


    [JsonPropertyName("blkio_stats")]
    public ContainerBlkioStats? Blkio_stats { get; set; } = default!;

    /// <summary>
    /// The number of processors on the system.
    /// <br/>
    /// <br/>This field is Windows-specific and always zero for Linux containers.
    /// <br/>
    /// </summary>

    [JsonPropertyName("num_procs")]
    public int? Num_procs { get; set; } = default!;


    [JsonPropertyName("storage_stats")]
    public ContainerStorageStats? Storage_stats { get; set; } = default!;


    [JsonPropertyName("cpu_stats")]
    public ContainerCPUStats? Cpu_stats { get; set; } = default!;


    [JsonPropertyName("precpu_stats")]
    public ContainerCPUStats? Precpu_stats { get; set; } = default!;


    [JsonPropertyName("memory_stats")]
    public ContainerMemoryStats? Memory_stats { get; set; } = default!;

    /// <summary>
    /// Network statistics for the container per interface.
    /// <br/>
    /// <br/>This field is omitted if the container has no networking enabled.
    /// <br/>
    /// </summary>

    [JsonPropertyName("networks")]
    public Networks? Networks { get; set; } = default!;


}