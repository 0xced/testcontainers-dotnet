using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class NetworkCreateResponse
{
    /// <summary>
    /// The ID of the created network.
    /// </summary>

    [JsonPropertyName("Id")]
    public string? Id { get; set; } = default!;


    [JsonPropertyName("Warning")]
    public string? Warning { get; set; } = default!;


}