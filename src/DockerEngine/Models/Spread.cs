using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class Spread
{
    /// <summary>
    /// label descriptor, such as `engine.labels.az`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("SpreadDescriptor")]
    public string? SpreadDescriptor { get; set; } = default!;


}