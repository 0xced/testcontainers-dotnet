using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// OK response to ContainerTop operation
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerTopResponse
{
    /// <summary>
    /// The ps column titles
    /// </summary>

    [JsonPropertyName("Titles")]
    public ICollection<string>? Titles { get; set; } = default!;

    /// <summary>
    /// Each process running in the container, where each is process
    /// <br/>is an array of values corresponding to the titles.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Processes")]
    public ICollection<ICollection<string>>? Processes { get; set; } = default!;


}