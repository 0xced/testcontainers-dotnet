namespace DockerEngine;

/// <summary>
/// Blkio stats entry.
/// <br/>
/// <br/>This type is Linux-specific and omitted for Windows containers.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerBlkioStatEntry
{

    [JsonPropertyName("major")]
    public ulong? Major { get; set; } = default!;


    [JsonPropertyName("minor")]
    public ulong? Minor { get; set; } = default!;


    [JsonPropertyName("op")]
    public string? Op { get; set; } = default!;


    [JsonPropertyName("value")]
    public ulong? Value { get; set; } = default!;


}