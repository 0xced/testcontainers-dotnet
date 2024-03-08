using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Health stores information about the container's healthcheck results.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Health
{
    /// <summary>
    /// Status is one of `none`, `starting`, `healthy` or `unhealthy`
    /// <br/>
    /// <br/>- "none"      Indicates there is no healthcheck
    /// <br/>- "starting"  Starting indicates that the container is not yet ready
    /// <br/>- "healthy"   Healthy indicates that the container is running correctly
    /// <br/>- "unhealthy" Unhealthy indicates that the container has a problem
    /// <br/>
    /// </summary>

    [JsonPropertyName("Status")]
    [JsonConverter(typeof(JsonEnumMemberConverter<HealthStatus>))]
    public HealthStatus? Status { get; set; } = default!;

    /// <summary>
    /// FailingStreak is the number of consecutive failures
    /// </summary>

    [JsonPropertyName("FailingStreak")]
    public int? FailingStreak { get; set; } = default!;

    /// <summary>
    /// Log contains the last few results (oldest first)
    /// <br/>
    /// </summary>

    [JsonPropertyName("Log")]
    public System.Collections.Generic.ICollection<HealthcheckResult?>? Log { get; set; } = default!;


}