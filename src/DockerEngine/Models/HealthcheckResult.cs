using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// HealthcheckResult stores information about a single run of a healthcheck probe
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class HealthcheckResult
{
    /// <summary>
    /// Date and time at which this check started in
    /// <br/>[RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) format with nano-seconds.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Start")]
    public DateTimeOffset? Start { get; set; } = default!;

    /// <summary>
    /// Date and time at which this check ended in
    /// <br/>[RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) format with nano-seconds.
    /// <br/>
    /// </summary>

    [JsonPropertyName("End")]
    public string? End { get; set; } = default!;

    /// <summary>
    /// ExitCode meanings:
    /// <br/>
    /// <br/>- `0` healthy
    /// <br/>- `1` unhealthy
    /// <br/>- `2` reserved (considered unhealthy)
    /// <br/>- other values: error running probe
    /// <br/>
    /// </summary>

    [JsonPropertyName("ExitCode")]
    public int? ExitCode { get; set; } = default!;

    /// <summary>
    /// Output from last check
    /// </summary>

    [JsonPropertyName("Output")]
    public string? Output { get; set; } = default!;


}