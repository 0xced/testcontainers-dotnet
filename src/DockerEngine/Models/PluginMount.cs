using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PluginMount
{

    [JsonPropertyName("Name")]
    public string Name { get; set; } = default!;


    [JsonPropertyName("Description")]
    public string Description { get; set; } = default!;


    [JsonPropertyName("Settable")]
    public ICollection<string> Settable { get; set; } = new List<string>();


    [JsonPropertyName("Source")]
    public string Source { get; set; } = default!;


    [JsonPropertyName("Destination")]
    public string Destination { get; set; } = default!;


    [JsonPropertyName("Type")]
    public string Type { get; set; } = default!;


    [JsonPropertyName("Options")]
    public ICollection<string> Options { get; set; } = new List<string>();


}