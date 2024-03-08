using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ProgressDetail
{

    [JsonPropertyName("current")]
    public int? Current { get; set; } = default!;


    [JsonPropertyName("total")]
    public int? Total { get; set; } = default!;


}