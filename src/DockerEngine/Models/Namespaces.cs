namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class Namespaces
{
    /// <summary>
    /// The default containerd namespace used for containers managed
    /// <br/>by the daemon.
    /// <br/>
    /// <br/>The default namespace for containers is "moby", but will be
    /// <br/>suffixed with the `&lt;uid&gt;.&lt;gid&gt;` of the remapped `root` if
    /// <br/>user-namespaces are enabled and the containerd image-store
    /// <br/>is used.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Containers")]
    public string? Containers { get; set; } = "moby";

    /// <summary>
    /// The default containerd namespace used for plugins managed by
    /// <br/>the daemon.
    /// <br/>
    /// <br/>The default namespace for plugins is "plugins.moby", but will be
    /// <br/>suffixed with the `&lt;uid&gt;.&lt;gid&gt;` of the remapped `root` if
    /// <br/>user-namespaces are enabled and the containerd image-store
    /// <br/>is used.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Plugins")]
    public string? Plugins { get; set; } = "plugins.moby";


}