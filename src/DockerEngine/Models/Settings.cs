namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class Settings
{

    [JsonPropertyName("Mounts")]
    public ICollection<PluginMount> Mounts { get; set; } = new List<PluginMount>();


    [JsonPropertyName("Env")]
    public ICollection<string> Env { get; set; } = new List<string>();


    [JsonPropertyName("Args")]
    public ICollection<string> Args { get; set; } = new List<string>();


    [JsonPropertyName("Devices")]
    public ICollection<PluginDevice> Devices { get; set; } = new List<PluginDevice>();


}