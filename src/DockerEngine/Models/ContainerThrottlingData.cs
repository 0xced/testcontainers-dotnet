namespace DockerEngine;

/// <summary>
/// CPU throttling stats of the container.
/// <br/>
/// <br/>This type is Linux-specific and omitted for Windows containers.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerThrottlingData
{
    /// <summary>
    /// Number of periods with throttling active.
    /// <br/>
    /// </summary>

    [JsonPropertyName("periods")]
    public ulong? Periods { get; set; } = default!;

    /// <summary>
    /// Number of periods when the container hit its throttling limit.
    /// <br/>
    /// </summary>

    [JsonPropertyName("throttled_periods")]
    public ulong? Throttled_periods { get; set; } = default!;

    /// <summary>
    /// Aggregated time (in nanoseconds) the container was throttled for.
    /// <br/>
    /// </summary>

    [JsonPropertyName("throttled_time")]
    public ulong? Throttled_time { get; set; } = default!;


}