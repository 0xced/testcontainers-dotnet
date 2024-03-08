using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// A test to perform to check that the container is healthy.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class HealthConfig
{
    /// <summary>
    /// The test to perform. Possible values are:
    /// <br/>
    /// <br/>- `[]` inherit healthcheck from image or parent image
    /// <br/>- `["NONE"]` disable healthcheck
    /// <br/>- `["CMD", args...]` exec arguments directly
    /// <br/>- `["CMD-SHELL", command]` run command with system's default shell
    /// <br/>
    /// </summary>

    [JsonPropertyName("Test")]
    public System.Collections.Generic.ICollection<string>? Test { get; set; } = default!;

    /// <summary>
    /// The time to wait between checks in nanoseconds. It should be 0 or at
    /// <br/>least 1000000 (1 ms). 0 means inherit.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Interval")]
    public long? Interval { get; set; } = default!;

    /// <summary>
    /// The time to wait before considering the check to have hung. It should
    /// <br/>be 0 or at least 1000000 (1 ms). 0 means inherit.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Timeout")]
    public long? Timeout { get; set; } = default!;

    /// <summary>
    /// The number of consecutive failures needed to consider a container as
    /// <br/>unhealthy. 0 means inherit.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Retries")]
    public int? Retries { get; set; } = default!;

    /// <summary>
    /// Start period for the container to initialize before starting
    /// <br/>health-retries countdown in nanoseconds. It should be 0 or at least
    /// <br/>1000000 (1 ms). 0 means inherit.
    /// <br/>
    /// </summary>

    [JsonPropertyName("StartPeriod")]
    public long? StartPeriod { get; set; } = default!;

    /// <summary>
    /// The time to wait between checks in nanoseconds during the start period.
    /// <br/>It should be 0 or at least 1000000 (1 ms). 0 means inherit.
    /// <br/>
    /// </summary>

    [JsonPropertyName("StartInterval")]
    public long? StartInterval { get; set; } = default!;


}