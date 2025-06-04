namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class RootFS
{

    [JsonPropertyName("Type")]
    public string Type { get; set; } = default!;


    [JsonPropertyName("Layers")]
    public ICollection<string>? Layers { get; set; } = default!;


}