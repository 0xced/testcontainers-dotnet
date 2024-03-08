using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ThrottleDevice
{
    /// <summary>
    /// Device path
    /// </summary>

    [JsonPropertyName("Path")]
    public string? Path { get; set; } = default!;

    /// <summary>
    /// Rate
    /// </summary>

    [JsonPropertyName("Rate")]
    public long? Rate { get; set; } = default!;


}