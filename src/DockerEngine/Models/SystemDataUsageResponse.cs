using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SystemDataUsageResponse
{

    [JsonPropertyName("LayersSize")]
    public long? LayersSize { get; set; } = default!;


    [JsonPropertyName("Images")]
    public System.Collections.Generic.ICollection<ImageSummary>? Images { get; set; } = default!;


    [JsonPropertyName("Containers")]
    public System.Collections.Generic.ICollection<ContainerSummary>? Containers { get; set; } = default!;


    [JsonPropertyName("Volumes")]
    public System.Collections.Generic.ICollection<Volume>? Volumes { get; set; } = default!;


    [JsonPropertyName("BuildCache")]
    public System.Collections.Generic.ICollection<BuildCache>? BuildCache { get; set; } = default!;


}