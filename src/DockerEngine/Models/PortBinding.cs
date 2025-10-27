namespace DockerEngine;

/// <summary>
/// PortBinding represents a binding between a host IP address and a host
/// <br/>port.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class PortBinding
{
    /// <summary>
    /// Host IP address that the container's port is mapped to.
    /// </summary>

    [JsonPropertyName("HostIp")]
    public string? HostIp { get; set; } = default!;

    /// <summary>
    /// Host port number that the container's port is mapped to.
    /// </summary>

    [JsonPropertyName("HostPort")]
    public string? HostPort { get; set; } = default!;


}