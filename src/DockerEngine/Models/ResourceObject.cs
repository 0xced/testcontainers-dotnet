using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// An object describing the resources which can be advertised by a node and
/// <br/>requested by a task.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ResourceObject
{

    [JsonPropertyName("NanoCPUs")]
    public long? NanoCPUs { get; set; } = default!;


    [JsonPropertyName("MemoryBytes")]
    public long? MemoryBytes { get; set; } = default!;


    [JsonPropertyName("GenericResources")]
    public GenericResources? GenericResources { get; set; } = default!;


}