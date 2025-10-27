namespace DockerEngine;

/// <summary>
/// A device mapping between the host and container
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class DeviceMapping
{

    [JsonPropertyName("PathOnHost")]
    public string? PathOnHost { get; set; } = default!;


    [JsonPropertyName("PathInContainer")]
    public string? PathInContainer { get; set; } = default!;


    [JsonPropertyName("CgroupPermissions")]
    public string? CgroupPermissions { get; set; } = default!;


}