using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Response to an API call that returns just an Id
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class IdResponse
{
    /// <summary>
    /// The id of the newly created object.
    /// </summary>

    [JsonPropertyName("Id")]
    public string Id { get; set; } = default!;


}