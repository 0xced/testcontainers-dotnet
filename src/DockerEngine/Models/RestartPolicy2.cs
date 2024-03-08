using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class RestartPolicy2
{
    /// <summary>
    /// Condition for restart.
    /// </summary>

    [JsonPropertyName("Condition")]
    [JsonConverter(typeof(JsonEnumMemberConverter<RestartPolicy2Condition>))]
    public RestartPolicy2Condition? Condition { get; set; } = default!;

    /// <summary>
    /// Delay between restart attempts.
    /// </summary>

    [JsonPropertyName("Delay")]
    public long? Delay { get; set; } = default!;

    /// <summary>
    /// Maximum attempts to restart a given container before giving up
    /// <br/>(default value is 0, which is ignored).
    /// <br/>
    /// </summary>

    [JsonPropertyName("MaxAttempts")]
    public long? MaxAttempts { get; set; } = 0L;

    /// <summary>
    /// Windows is the time window used to evaluate the restart policy
    /// <br/>(default value is 0, which is unbounded).
    /// <br/>
    /// </summary>

    [JsonPropertyName("Window")]
    public long? Window { get; set; } = 0L;


}