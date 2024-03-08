using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// NodeDescription encapsulates the properties of the Node as reported by the
/// <br/>agent.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class NodeDescription
{

    [JsonPropertyName("Hostname")]
    public string? Hostname { get; set; } = default!;


    [JsonPropertyName("Platform")]
    public Platform? Platform { get; set; } = default!;


    [JsonPropertyName("Resources")]
    public ResourceObject? Resources { get; set; } = default!;


    [JsonPropertyName("Engine")]
    public EngineDescription? Engine { get; set; } = default!;


    [JsonPropertyName("TLSInfo")]
    public TLSInfo? TLSInfo { get; set; } = default!;


}