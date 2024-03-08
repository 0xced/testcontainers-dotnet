using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateConfig
{
    /// <summary>
    /// Maximum number of tasks to be updated in one iteration (0 means
    /// <br/>unlimited parallelism).
    /// <br/>
    /// </summary>

    [JsonPropertyName("Parallelism")]
    public long? Parallelism { get; set; } = default!;

    /// <summary>
    /// Amount of time between updates, in nanoseconds.
    /// </summary>

    [JsonPropertyName("Delay")]
    public long? Delay { get; set; } = default!;

    /// <summary>
    /// Action to take if an updated task fails to run, or stops running
    /// <br/>during the update.
    /// <br/>
    /// </summary>

    [JsonPropertyName("FailureAction")]
    [JsonConverter(typeof(JsonEnumMemberConverter<UpdateConfigFailureAction>))]
    public UpdateConfigFailureAction? FailureAction { get; set; } = default!;

    /// <summary>
    /// Amount of time to monitor each updated task for failures, in
    /// <br/>nanoseconds.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Monitor")]
    public long? Monitor { get; set; } = default!;

    /// <summary>
    /// The fraction of tasks that may fail during an update before the
    /// <br/>failure action is invoked, specified as a floating point number
    /// <br/>between 0 and 1.
    /// <br/>
    /// </summary>

    [JsonPropertyName("MaxFailureRatio")]
    public double? MaxFailureRatio { get; set; } = 0D;

    /// <summary>
    /// The order of operations when rolling out an updated task. Either
    /// <br/>the old task is shut down before the new task is started, or the
    /// <br/>new task is started before the old task is shut down.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Order")]
    [JsonConverter(typeof(JsonEnumMemberConverter<UpdateConfigOrder>))]
    public UpdateConfigOrder? Order { get; set; } = default!;


}