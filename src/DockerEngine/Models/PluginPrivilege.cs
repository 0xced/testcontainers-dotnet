using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Describes a permission the user has to accept upon installing
/// <br/>the plugin.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PluginPrivilege
{

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;


    [JsonPropertyName("Description")]
    public string? Description { get; set; } = default!;


    [JsonPropertyName("Value")]
    public ICollection<string>? Value { get; set; } = default!;


}