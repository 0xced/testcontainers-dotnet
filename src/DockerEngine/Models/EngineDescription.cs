namespace DockerEngine;

/// <summary>
/// EngineDescription provides information about an engine.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class EngineDescription
{

    [JsonPropertyName("EngineVersion")]
    public string? EngineVersion { get; set; } = default!;


    [JsonPropertyName("Labels")]
    public IDictionary<string, string>? Labels { get; set; } = default!;


    [JsonPropertyName("Plugins")]
    public ICollection<Plugins>? Plugins { get; set; } = default!;


}