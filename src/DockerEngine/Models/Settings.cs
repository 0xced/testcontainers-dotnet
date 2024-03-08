using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Settings
{

    [JsonPropertyName("Mounts")]
    public System.Collections.Generic.ICollection<PluginMount> Mounts { get; set; } = new System.Collections.ObjectModel.Collection<PluginMount>();


    [JsonPropertyName("Env")]
    public System.Collections.Generic.ICollection<string> Env { get; set; } = new System.Collections.ObjectModel.Collection<string>();


    [JsonPropertyName("Args")]
    public System.Collections.Generic.ICollection<string> Args { get; set; } = new System.Collections.ObjectModel.Collection<string>();


    [JsonPropertyName("Devices")]
    public System.Collections.Generic.ICollection<PluginDevice> Devices { get; set; } = new System.Collections.ObjectModel.Collection<PluginDevice>();


}