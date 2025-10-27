namespace DockerEngine;

/// <summary>
/// DeviceInfo represents a device that can be used by a container.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class DeviceInfo
{
    /// <summary>
    /// The origin device driver.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Source")]
    public string? Source { get; set; } = default!;

    /// <summary>
    /// The unique identifier for the device within its source driver.
    /// <br/>For CDI devices, this would be an FQDN like "vendor.com/gpu=0".
    /// <br/>
    /// </summary>

    [JsonPropertyName("ID")]
    public string? ID { get; set; } = default!;


}