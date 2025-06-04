namespace DockerEngine;

/// <summary>
/// OK response to ContainerWait operation
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerWaitResponse
{
    /// <summary>
    /// Exit code of the container
    /// </summary>

    [JsonPropertyName("StatusCode")]
    public long StatusCode { get; set; } = default!;


    [JsonPropertyName("Error")]
    public ContainerWaitExitError? Error { get; set; } = default!;


}