namespace DockerEngine;

/// <summary>
/// Aggregates all memory stats since container inception on Linux.
/// <br/>Windows returns stats for commit and private working set only.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerMemoryStats
{
    /// <summary>
    /// Current `res_counter` usage for memory.
    /// <br/>
    /// <br/>This field is Linux-specific and omitted for Windows containers.
    /// <br/>
    /// </summary>

    [JsonPropertyName("usage")]
    public ulong? Usage { get; set; } = default!;

    /// <summary>
    /// Maximum usage ever recorded.
    /// <br/>
    /// <br/>This field is Linux-specific and only supported on cgroups v1.
    /// <br/>It is omitted when using cgroups v2 and for Windows containers.
    /// <br/>
    /// </summary>

    [JsonPropertyName("max_usage")]
    public ulong? Max_usage { get; set; } = default!;

    /// <summary>
    /// All the stats exported via memory.stat. when using cgroups v2.
    /// <br/>
    /// <br/>This field is Linux-specific and omitted for Windows containers.
    /// <br/>
    /// </summary>

    [JsonPropertyName("stats")]
    public IDictionary<string, ulong?>? Stats { get; set; } = default!;

    /// <summary>
    /// Number of times memory usage hits limits.
    /// <br/>
    /// <br/>This field is Linux-specific and only supported on cgroups v1.
    /// <br/>It is omitted when using cgroups v2 and for Windows containers.
    /// <br/>
    /// </summary>

    [JsonPropertyName("failcnt")]
    public ulong? Failcnt { get; set; } = default!;

    /// <summary>
    /// This field is Linux-specific and omitted for Windows containers.
    /// <br/>
    /// </summary>

    [JsonPropertyName("limit")]
    public ulong? Limit { get; set; } = default!;

    /// <summary>
    /// Committed bytes.
    /// <br/>
    /// <br/>This field is Windows-specific and omitted for Linux containers.
    /// <br/>
    /// </summary>

    [JsonPropertyName("commitbytes")]
    public ulong? Commitbytes { get; set; } = default!;

    /// <summary>
    /// Peak committed bytes.
    /// <br/>
    /// <br/>This field is Windows-specific and omitted for Linux containers.
    /// <br/>
    /// </summary>

    [JsonPropertyName("commitpeakbytes")]
    public ulong? Commitpeakbytes { get; set; } = default!;

    /// <summary>
    /// Private working set.
    /// <br/>
    /// <br/>This field is Windows-specific and omitted for Linux containers.
    /// <br/>
    /// </summary>

    [JsonPropertyName("privateworkingset")]
    public ulong? Privateworkingset { get; set; } = default!;


}