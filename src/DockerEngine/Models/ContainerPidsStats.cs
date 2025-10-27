namespace DockerEngine;

/// <summary>
/// PidsStats contains Linux-specific stats of a container's process-IDs (PIDs).
/// <br/>
/// <br/>This type is Linux-specific and omitted for Windows containers.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerPidsStats
{
    /// <summary>
    /// Current is the number of PIDs in the cgroup.
    /// <br/>
    /// </summary>

    [JsonPropertyName("current")]
    public ulong? Current { get; set; } = default!;

    /// <summary>
    /// Limit is the hard limit on the number of pids in the cgroup.
    /// <br/>A "Limit" of 0 means that there is no limit.
    /// <br/>
    /// </summary>

    [JsonPropertyName("limit")]
    public ulong? Limit { get; set; } = default!;


}