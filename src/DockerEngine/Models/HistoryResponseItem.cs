namespace DockerEngine;

/// <summary>
/// individual image layer information in response to ImageHistory operation
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class HistoryResponseItem
{

    [JsonPropertyName("Id")]
    public string Id { get; set; } = default!;


    [JsonPropertyName("Created")]
    public long Created { get; set; } = default!;


    [JsonPropertyName("CreatedBy")]
    public string CreatedBy { get; set; } = default!;


    [JsonPropertyName("Tags")]
    public ICollection<string> Tags { get; set; } = new List<string>();


    [JsonPropertyName("Size")]
    public long Size { get; set; } = default!;


    [JsonPropertyName("Comment")]
    public string Comment { get; set; } = default!;


}