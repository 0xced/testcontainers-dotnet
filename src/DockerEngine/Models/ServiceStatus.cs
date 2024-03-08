using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ServiceStatus
{
    /// <summary>
    /// The number of tasks for the service currently in the Running state.
    /// <br/>
    /// </summary>

    [JsonPropertyName("RunningTasks")]
    public ulong? RunningTasks { get; set; } = default!;

    /// <summary>
    /// The number of tasks for the service desired to be running.
    /// <br/>For replicated services, this is the replica count from the
    /// <br/>service spec. For global services, this is computed by taking
    /// <br/>count of all tasks for the service with a Desired State other
    /// <br/>than Shutdown.
    /// <br/>
    /// </summary>

    [JsonPropertyName("DesiredTasks")]
    public ulong? DesiredTasks { get; set; } = default!;

    /// <summary>
    /// The number of tasks for a job that are in the Completed state.
    /// <br/>This field must be cross-referenced with the service type, as the
    /// <br/>value of 0 may mean the service is not in a job mode, or it may
    /// <br/>mean the job-mode service has no tasks yet Completed.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CompletedTasks")]
    public ulong? CompletedTasks { get; set; } = default!;


}