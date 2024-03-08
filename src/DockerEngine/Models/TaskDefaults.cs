using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TaskDefaults
{
    /// <summary>
    /// The log driver to use for tasks created in the orchestrator if
    /// <br/>unspecified by a service.
    /// <br/>
    /// <br/>Updating this value only affects new tasks. Existing tasks continue
    /// <br/>to use their previously configured log driver until recreated.
    /// <br/>
    /// </summary>

    [JsonPropertyName("LogDriver")]
    public LogDriver2? LogDriver { get; set; } = default!;


}