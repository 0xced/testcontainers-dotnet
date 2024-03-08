using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// One cluster volume secret entry. Defines a key-value pair that
/// <br/>is passed to the plugin.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Secrets2
{
    /// <summary>
    /// Key is the name of the key of the key-value pair passed to
    /// <br/>the plugin.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Key")]
    public string? Key { get; set; } = default!;

    /// <summary>
    /// Secret is the swarm Secret object from which to read data.
    /// <br/>This can be a Secret name or ID. The Secret data is
    /// <br/>retrieved by swarm and used as the value of the key-value
    /// <br/>pair passed to the plugin.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Secret")]
    public string? Secret { get; set; } = default!;


}