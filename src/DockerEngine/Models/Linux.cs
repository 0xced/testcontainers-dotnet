namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class Linux
{

    [JsonPropertyName("Capabilities")]
    public ICollection<string> Capabilities { get; set; } = new List<string>();


    [JsonPropertyName("AllowAllDevices")]
    public bool AllowAllDevices { get; set; } = default!;


    [JsonPropertyName("Devices")]
    public ICollection<PluginDevice> Devices { get; set; } = new List<PluginDevice>();


}