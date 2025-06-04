using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class CapacityRange
{
    /// <summary>
    /// The volume must be at least this big. The value of 0
    /// <br/>indicates an unspecified minimum
    /// <br/>
    /// </summary>

    [JsonPropertyName("RequiredBytes")]
    public long? RequiredBytes { get; set; } = default!;

    /// <summary>
    /// The volume must not be bigger than this. The value of 0
    /// <br/>indicates an unspecified maximum.
    /// <br/>
    /// </summary>

    [JsonPropertyName("LimitBytes")]
    public long? LimitBytes { get; set; } = default!;


}