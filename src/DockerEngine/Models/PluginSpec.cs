using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PluginSpec
{
    /// <summary>
    /// The name or 'alias' to use for the plugin.
    /// </summary>

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;

    /// <summary>
    /// The plugin image reference to use.
    /// </summary>

    [JsonPropertyName("Remote")]
    public string? Remote { get; set; } = default!;

    /// <summary>
    /// Disable the plugin once scheduled.
    /// </summary>

    [JsonPropertyName("Disabled")]
    public bool? Disabled { get; set; } = default!;


    [JsonPropertyName("PluginPrivilege")]
    public ICollection<PluginPrivilege>? PluginPrivilege { get; set; } = default!;


}