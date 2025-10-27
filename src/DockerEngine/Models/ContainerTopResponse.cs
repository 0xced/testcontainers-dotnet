namespace DockerEngine;

/// <summary>
/// Container "top" response.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerTopResponse
{
    /// <summary>
    /// The ps column titles
    /// </summary>

    [JsonPropertyName("Titles")]
    public ICollection<string>? Titles { get; set; } = default!;

    /// <summary>
    /// Each process running in the container, where each process
    /// <br/>is an array of values corresponding to the titles.
    /// </summary>

    [JsonPropertyName("Processes")]
    public ICollection<ICollection<string>>? Processes { get; set; } = default!;


}