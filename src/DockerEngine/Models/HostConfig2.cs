namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class HostConfig2
{
    /// <summary>
    /// Networking mode (`host`, `none`, `container:&lt;id&gt;`) or name of the
    /// <br/>primary network the container is using.
    /// <br/>
    /// <br/>This field is primarily for backward compatibility. The container
    /// <br/>can be connected to multiple networks for which information can be
    /// <br/>found in the `NetworkSettings.Networks` field, which enumerates
    /// <br/>settings per network.
    /// </summary>

    [JsonPropertyName("NetworkMode")]
    public string? NetworkMode { get; set; } = default!;

    /// <summary>
    /// Arbitrary key-value metadata attached to the container.
    /// </summary>

    [JsonPropertyName("Annotations")]
    public IDictionary<string, string>? Annotations { get; set; } = default!;


}