using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Interface
{

    [JsonPropertyName("Types")]
    public System.Collections.Generic.ICollection<PluginInterfaceType> Types { get; set; } = new System.Collections.ObjectModel.Collection<PluginInterfaceType>();


    [JsonPropertyName("Socket")]
    public string Socket { get; set; } = default!;

    /// <summary>
    /// Protocol to use for clients connecting to the plugin.
    /// </summary>

    [JsonPropertyName("ProtocolScheme")]
    [JsonConverter(typeof(JsonEnumMemberConverter<InterfaceProtocolScheme>))]
    public InterfaceProtocolScheme? ProtocolScheme { get; set; } = default!;


}