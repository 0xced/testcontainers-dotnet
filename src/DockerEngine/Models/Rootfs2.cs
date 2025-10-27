namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class Rootfs
{

    [JsonPropertyName("type")]
    public string? Type { get; set; } = default!;


    [JsonPropertyName("diff_ids")]
    public ICollection<string>? Diff_ids { get; set; } = default!;


}