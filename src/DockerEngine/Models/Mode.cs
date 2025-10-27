namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class Mode
{

    [JsonPropertyName("Replicated")]
    public Replicated? Replicated { get; set; } = default!;


    [JsonPropertyName("Global")]
    public object? Global { get; set; } = default!;

    /// <summary>
    /// The mode used for services with a finite number of tasks that run
    /// <br/>to a completed state.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ReplicatedJob")]
    public ReplicatedJob? ReplicatedJob { get; set; } = default!;

    /// <summary>
    /// The mode used for services which run a task to the completed state
    /// <br/>on each valid node.
    /// <br/>
    /// </summary>

    [JsonPropertyName("GlobalJob")]
    public object? GlobalJob { get; set; } = default!;


}