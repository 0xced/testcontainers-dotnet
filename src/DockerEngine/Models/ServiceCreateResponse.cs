using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// contains the information returned to a client on the
/// <br/>creation of a new service.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ServiceCreateResponse
{
    /// <summary>
    /// The ID of the created service.
    /// </summary>

    [JsonPropertyName("ID")]
    public string? ID { get; set; } = default!;

    /// <summary>
    /// Optional warning message.
    /// <br/>
    /// <br/>FIXME(thaJeztah): this should have "omitempty" in the generated type.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Warnings")]
    public ICollection<string>? Warnings { get; set; } = default!;


}