namespace DockerEngine;

/// <summary>
/// Information for connecting to the containerd instance that is used by the daemon.
/// <br/>This is included for debugging purposes only.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerdInfo
{
    /// <summary>
    /// The address of the containerd socket.
    /// </summary>

    [JsonPropertyName("Address")]
    public string? Address { get; set; } = default!;

    /// <summary>
    /// The namespaces that the daemon uses for running containers and
    /// <br/>plugins in containerd. These namespaces can be configured in the
    /// <br/>daemon configuration, and are considered to be used exclusively
    /// <br/>by the daemon, Tampering with the containerd instance may cause
    /// <br/>unexpected behavior.
    /// <br/>
    /// <br/>As these namespaces are considered to be exclusively accessed
    /// <br/>by the daemon, it is not recommended to change these values,
    /// <br/>or to change them to a value that is used by other systems,
    /// <br/>such as cri-containerd.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Namespaces")]
    public Namespaces? Namespaces { get; set; } = default!;


}