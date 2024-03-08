using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Linux
{

    [JsonPropertyName("Capabilities")]
    public System.Collections.Generic.ICollection<string> Capabilities { get; set; } = new System.Collections.ObjectModel.Collection<string>();


    [JsonPropertyName("AllowAllDevices")]
    public bool AllowAllDevices { get; set; } = default!;


    [JsonPropertyName("Devices")]
    public System.Collections.Generic.ICollection<PluginDevice> Devices { get; set; } = new System.Collections.ObjectModel.Collection<PluginDevice>();


}