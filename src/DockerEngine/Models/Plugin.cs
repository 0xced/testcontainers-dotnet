using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// A plugin for the Engine API
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Plugin
{

    [JsonPropertyName("Id")]
    public string? Id { get; set; } = default!;


    [JsonPropertyName("Name")]
    public string Name { get; set; } = default!;

    /// <summary>
    /// True if the plugin is running. False if the plugin is not running, only installed.
    /// </summary>

    [JsonPropertyName("Enabled")]
    public bool Enabled { get; set; } = default!;

    /// <summary>
    /// Settings that can be modified by users.
    /// </summary>

    [JsonPropertyName("Settings")]
    public Settings Settings { get; set; } = new Settings();

    /// <summary>
    /// plugin remote reference used to push/pull the plugin
    /// </summary>

    [JsonPropertyName("PluginReference")]
    public string? PluginReference { get; set; } = default!;

    /// <summary>
    /// The config of a plugin.
    /// </summary>

    [JsonPropertyName("Config")]
    public Config2 Config { get; set; } = new Config2();


}