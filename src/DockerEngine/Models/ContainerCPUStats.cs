namespace DockerEngine;

/// <summary>
/// CPU related info of the container
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerCPUStats
{

    [JsonPropertyName("cpu_usage")]
    public ContainerCPUUsage? Cpu_usage { get; set; } = default!;

    /// <summary>
    /// System Usage.
    /// <br/>
    /// <br/>This field is Linux-specific and omitted for Windows containers.
    /// <br/>
    /// </summary>

    [JsonPropertyName("system_cpu_usage")]
    public ulong? System_cpu_usage { get; set; } = default!;

    /// <summary>
    /// Number of online CPUs.
    /// <br/>
    /// <br/>This field is Linux-specific and omitted for Windows containers.
    /// <br/>
    /// </summary>

    [JsonPropertyName("online_cpus")]
    public int? Online_cpus { get; set; } = default!;


    [JsonPropertyName("throttling_data")]
    public ContainerThrottlingData? Throttling_data { get; set; } = default!;


}