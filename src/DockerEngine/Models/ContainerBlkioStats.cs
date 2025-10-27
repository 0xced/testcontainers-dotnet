namespace DockerEngine;

/// <summary>
/// BlkioStats stores all IO service stats for data read and write.
/// <br/>
/// <br/>This type is Linux-specific and holds many fields that are specific to cgroups v1.
/// <br/>On a cgroup v2 host, all fields other than `io_service_bytes_recursive`
/// <br/>are omitted or `null`.
/// <br/>
/// <br/>This type is only populated on Linux and omitted for Windows containers.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerBlkioStats
{

    [JsonPropertyName("io_service_bytes_recursive")]
    public ICollection<ContainerBlkioStatEntry?>? Io_service_bytes_recursive { get; set; } = default!;

    /// <summary>
    /// This field is only available when using Linux containers with
    /// <br/>cgroups v1. It is omitted or `null` when using cgroups v2.
    /// <br/>
    /// </summary>

    [JsonPropertyName("io_serviced_recursive")]
    public ICollection<ContainerBlkioStatEntry?>? Io_serviced_recursive { get; set; } = default!;

    /// <summary>
    /// This field is only available when using Linux containers with
    /// <br/>cgroups v1. It is omitted or `null` when using cgroups v2.
    /// <br/>
    /// </summary>

    [JsonPropertyName("io_queue_recursive")]
    public ICollection<ContainerBlkioStatEntry?>? Io_queue_recursive { get; set; } = default!;

    /// <summary>
    /// This field is only available when using Linux containers with
    /// <br/>cgroups v1. It is omitted or `null` when using cgroups v2.
    /// <br/>
    /// </summary>

    [JsonPropertyName("io_service_time_recursive")]
    public ICollection<ContainerBlkioStatEntry?>? Io_service_time_recursive { get; set; } = default!;

    /// <summary>
    /// This field is only available when using Linux containers with
    /// <br/>cgroups v1. It is omitted or `null` when using cgroups v2.
    /// <br/>
    /// </summary>

    [JsonPropertyName("io_wait_time_recursive")]
    public ICollection<ContainerBlkioStatEntry?>? Io_wait_time_recursive { get; set; } = default!;

    /// <summary>
    /// This field is only available when using Linux containers with
    /// <br/>cgroups v1. It is omitted or `null` when using cgroups v2.
    /// <br/>
    /// </summary>

    [JsonPropertyName("io_merged_recursive")]
    public ICollection<ContainerBlkioStatEntry?>? Io_merged_recursive { get; set; } = default!;

    /// <summary>
    /// This field is only available when using Linux containers with
    /// <br/>cgroups v1. It is omitted or `null` when using cgroups v2.
    /// <br/>
    /// </summary>

    [JsonPropertyName("io_time_recursive")]
    public ICollection<ContainerBlkioStatEntry?>? Io_time_recursive { get; set; } = default!;

    /// <summary>
    /// This field is only available when using Linux containers with
    /// <br/>cgroups v1. It is omitted or `null` when using cgroups v2.
    /// <br/>
    /// </summary>

    [JsonPropertyName("sectors_recursive")]
    public ICollection<ContainerBlkioStatEntry?>? Sectors_recursive { get; set; } = default!;


}