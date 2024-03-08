using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReplicatedJob
{
    /// <summary>
    /// The maximum number of replicas to run simultaneously.
    /// <br/>
    /// </summary>

    [JsonPropertyName("MaxConcurrent")]
    public long? MaxConcurrent { get; set; } = 1L;

    /// <summary>
    /// The total number of replicas desired to reach the Completed
    /// <br/>state. If unset, will default to the value of `MaxConcurrent`
    /// <br/>
    /// </summary>

    [JsonPropertyName("TotalCompletions")]
    public long? TotalCompletions { get; set; } = default!;


}