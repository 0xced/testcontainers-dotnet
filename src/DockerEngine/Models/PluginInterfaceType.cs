using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PluginInterfaceType
{

    [JsonPropertyName("Prefix")]
    public string Prefix { get; set; } = default!;


    [JsonPropertyName("Capability")]
    public string Capability { get; set; } = default!;


    [JsonPropertyName("Version")]
    public string Version { get; set; } = default!;


}