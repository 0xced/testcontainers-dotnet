namespace DockerEngine;

/// <summary>
/// All CPU stats aggregated since container inception.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerCPUUsage
{
    /// <summary>
    /// Total CPU time consumed in nanoseconds (Linux) or 100's of nanoseconds (Windows).
    /// <br/>
    /// </summary>

    [JsonPropertyName("total_usage")]
    public ulong? Total_usage { get; set; } = default!;

    /// <summary>
    /// Total CPU time (in nanoseconds) consumed per core (Linux).
    /// <br/>
    /// <br/>This field is Linux-specific when using cgroups v1. It is omitted
    /// <br/>when using cgroups v2 and Windows containers.
    /// <br/>
    /// </summary>

    [JsonPropertyName("percpu_usage")]
    public ICollection<ulong>? Percpu_usage { get; set; } = default!;

    /// <summary>
    /// Time (in nanoseconds) spent by tasks of the cgroup in kernel mode (Linux),
    /// <br/>or time spent (in 100's of nanoseconds) by all container processes in
    /// <br/>kernel mode (Windows).
    /// <br/>
    /// <br/>Not populated for Windows containers using Hyper-V isolation.
    /// <br/>
    /// </summary>

    [JsonPropertyName("usage_in_kernelmode")]
    public ulong? Usage_in_kernelmode { get; set; } = default!;

    /// <summary>
    /// Time (in nanoseconds) spent by tasks of the cgroup in user mode (Linux),
    /// <br/>or time spent (in 100's of nanoseconds) by all container processes in
    /// <br/>kernel mode (Windows).
    /// <br/>
    /// <br/>Not populated for Windows containers using Hyper-V isolation.
    /// <br/>
    /// </summary>

    [JsonPropertyName("usage_in_usermode")]
    public ulong? Usage_in_usermode { get; set; } = default!;


}