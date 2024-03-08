using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// JoinTokens contains the tokens workers and managers need to join the swarm.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class JoinTokens
{
    /// <summary>
    /// The token workers can use to join the swarm.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Worker")]
    public string? Worker { get; set; } = default!;

    /// <summary>
    /// The token managers can use to join the swarm.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Manager")]
    public string? Manager { get; set; } = default!;


}