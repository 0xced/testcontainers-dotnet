using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// An object describing a limit on resources which can be requested by a task.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Limit
{

    [JsonPropertyName("NanoCPUs")]
    public long? NanoCPUs { get; set; } = default!;


    [JsonPropertyName("MemoryBytes")]
    public long? MemoryBytes { get; set; } = default!;

    /// <summary>
    /// Limits the maximum number of PIDs in the container. Set `0` for unlimited.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Pids")]
    public long? Pids { get; set; } = 0L;


}