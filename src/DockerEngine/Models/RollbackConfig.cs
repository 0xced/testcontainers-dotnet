using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class RollbackConfig
{
    /// <summary>
    /// Maximum number of tasks to be rolled back in one iteration (0 means
    /// <br/>unlimited parallelism).
    /// <br/>
    /// </summary>

    [JsonPropertyName("Parallelism")]
    public long? Parallelism { get; set; } = default!;

    /// <summary>
    /// Amount of time between rollback iterations, in nanoseconds.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Delay")]
    public long? Delay { get; set; } = default!;

    /// <summary>
    /// Action to take if an rolled back task fails to run, or stops
    /// <br/>running during the rollback.
    /// <br/>
    /// </summary>

    [JsonPropertyName("FailureAction")]
    [JsonConverter(typeof(JsonEnumMemberConverter<RollbackConfigFailureAction>))]
    public RollbackConfigFailureAction? FailureAction { get; set; } = default!;

    /// <summary>
    /// Amount of time to monitor each rolled back task for failures, in
    /// <br/>nanoseconds.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Monitor")]
    public long? Monitor { get; set; } = default!;

    /// <summary>
    /// The fraction of tasks that may fail during a rollback before the
    /// <br/>failure action is invoked, specified as a floating point number
    /// <br/>between 0 and 1.
    /// <br/>
    /// </summary>

    [JsonPropertyName("MaxFailureRatio")]
    public double? MaxFailureRatio { get; set; } = 0D;

    /// <summary>
    /// The order of operations when rolling back a task. Either the old
    /// <br/>task is shut down before the new task is started, or the new task
    /// <br/>is started before the old task is shut down.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Order")]
    [JsonConverter(typeof(JsonEnumMemberConverter<RollbackConfigOrder>))]
    public RollbackConfigOrder? Order { get; set; } = default!;


}