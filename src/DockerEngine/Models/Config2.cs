using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Config2
{
    /// <summary>
    /// Docker Version used to create the plugin
    /// </summary>

    [JsonPropertyName("DockerVersion")]
    public string? DockerVersion { get; set; } = default!;


    [JsonPropertyName("Description")]
    public string Description { get; set; } = default!;


    [JsonPropertyName("Documentation")]
    public string Documentation { get; set; } = default!;

    /// <summary>
    /// The interface between Docker and the plugin
    /// </summary>

    [JsonPropertyName("Interface")]
    public Interface Interface { get; set; } = new Interface();


    [JsonPropertyName("Entrypoint")]
    public System.Collections.Generic.ICollection<string> Entrypoint { get; set; } = new System.Collections.ObjectModel.Collection<string>();


    [JsonPropertyName("WorkDir")]
    public string WorkDir { get; set; } = default!;


    [JsonPropertyName("User")]
    public User? User { get; set; } = default!;


    [JsonPropertyName("Network")]
    public Network2 Network { get; set; } = new Network2();


    [JsonPropertyName("Linux")]
    public Linux Linux { get; set; } = new Linux();


    [JsonPropertyName("PropagatedMount")]
    public string PropagatedMount { get; set; } = default!;


    [JsonPropertyName("IpcHost")]
    public bool IpcHost { get; set; } = default!;


    [JsonPropertyName("PidHost")]
    public bool PidHost { get; set; } = default!;


    [JsonPropertyName("Mounts")]
    public System.Collections.Generic.ICollection<PluginMount> Mounts { get; set; } = new System.Collections.ObjectModel.Collection<PluginMount>();


    [JsonPropertyName("Env")]
    public System.Collections.Generic.ICollection<PluginEnv> Env { get; set; } = new System.Collections.ObjectModel.Collection<PluginEnv>();


    [JsonPropertyName("Args")]
    public Args Args { get; set; } = new Args();


    [JsonPropertyName("rootfs")]
    public Rootfs? Rootfs { get; set; } = default!;


}