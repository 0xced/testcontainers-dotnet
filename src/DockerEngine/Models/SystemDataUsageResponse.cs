namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class SystemDataUsageResponse
{

    [JsonPropertyName("LayersSize")]
    public long? LayersSize { get; set; } = default!;


    [JsonPropertyName("Images")]
    public ICollection<ImageSummary>? Images { get; set; } = default!;


    [JsonPropertyName("Containers")]
    public ICollection<ContainerSummary>? Containers { get; set; } = default!;


    [JsonPropertyName("Volumes")]
    public ICollection<Volume>? Volumes { get; set; } = default!;


    [JsonPropertyName("BuildCache")]
    public ICollection<BuildCache>? BuildCache { get; set; } = default!;


}