namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class Orchestration
{
    /// <summary>
    /// The number of historic tasks to keep per instance or node. If
    /// <br/>negative, never remove completed or failed tasks.
    /// <br/>
    /// </summary>

    [JsonPropertyName("TaskHistoryRetentionLimit")]
    public long? TaskHistoryRetentionLimit { get; set; } = default!;


}