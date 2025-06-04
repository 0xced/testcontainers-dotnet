namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class Args
{

    [JsonPropertyName("Name")]
    public string Name { get; set; } = default!;


    [JsonPropertyName("Description")]
    public string Description { get; set; } = default!;


    [JsonPropertyName("Settable")]
    public ICollection<string> Settable { get; set; } = new List<string>();


    [JsonPropertyName("Value")]
    public ICollection<string> Value { get; set; } = new List<string>();


}