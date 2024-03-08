using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Rootfs
{

    [JsonPropertyName("type")]
    public string? Type { get; set; } = default!;


    [JsonPropertyName("diff_ids")]
    public System.Collections.Generic.ICollection<string>? Diff_ids { get; set; } = default!;


}