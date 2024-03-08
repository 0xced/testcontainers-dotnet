using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// OK response to ContainerCreate operation
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerCreateResponse
{
    /// <summary>
    /// The ID of the created container
    /// </summary>

    [JsonPropertyName("Id")]
    public string Id { get; set; } = default!;

    /// <summary>
    /// Warnings encountered when creating the container
    /// </summary>

    [JsonPropertyName("Warnings")]
    public ICollection<string> Warnings { get; set; } = new List<string>();


}