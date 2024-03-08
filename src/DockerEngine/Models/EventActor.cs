using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Actor describes something that generates events, like a container, network,
/// <br/>or a volume.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EventActor
{
    /// <summary>
    /// The ID of the object emitting the event
    /// </summary>

    [JsonPropertyName("ID")]
    public string? ID { get; set; } = default!;

    /// <summary>
    /// Various key/value attributes of the object, depending on its type.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Attributes")]
    public IDictionary<string, string>? Attributes { get; set; } = default!;


}