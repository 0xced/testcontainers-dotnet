namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class Secret
{

    [JsonPropertyName("ID")]
    public string? ID { get; set; } = default!;


    [JsonPropertyName("Version")]
    public ObjectVersion? Version { get; set; } = default!;


    [JsonPropertyName("CreatedAt")]
    public string? CreatedAt { get; set; } = default!;


    [JsonPropertyName("UpdatedAt")]
    public string? UpdatedAt { get; set; } = default!;


    [JsonPropertyName("Spec")]
    public SecretSpec? Spec { get; set; } = default!;


}