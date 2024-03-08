using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Interface
{

    [JsonPropertyName("Types")]
    public ICollection<PluginInterfaceType> Types { get; set; } = new List<PluginInterfaceType>();


    [JsonPropertyName("Socket")]
    public string Socket { get; set; } = default!;

    /// <summary>
    /// Protocol to use for clients connecting to the plugin.
    /// </summary>

    [JsonPropertyName("ProtocolScheme")]
    [JsonConverter(typeof(JsonEnumMemberConverter<InterfaceProtocolScheme>))]
    public InterfaceProtocolScheme? ProtocolScheme { get; set; } = default!;


}