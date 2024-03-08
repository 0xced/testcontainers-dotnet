using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class JobStatus
{
    /// <summary>
    /// JobIteration is a value increased each time a Job is executed,
    /// <br/>successfully or otherwise. "Executed", in this case, means the
    /// <br/>job as a whole has been started, not that an individual Task has
    /// <br/>been launched. A job is "Executed" when its ServiceSpec is
    /// <br/>updated. JobIteration can be used to disambiguate Tasks belonging
    /// <br/>to different executions of a job.  Though JobIteration will
    /// <br/>increase with each subsequent execution, it may not necessarily
    /// <br/>increase by 1, and so JobIteration should not be used to
    /// <br/>
    /// </summary>

    [JsonPropertyName("JobIteration")]
    public ObjectVersion? JobIteration { get; set; } = default!;

    /// <summary>
    /// The last time, as observed by the server, that this job was
    /// <br/>started.
    /// <br/>
    /// </summary>

    [JsonPropertyName("LastExecution")]
    public string? LastExecution { get; set; } = default!;


}