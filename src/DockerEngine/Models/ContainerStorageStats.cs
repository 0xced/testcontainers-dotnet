namespace DockerEngine;

/// <summary>
/// StorageStats is the disk I/O stats for read/write on Windows.
/// <br/>
/// <br/>This type is Windows-specific and omitted for Linux containers.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerStorageStats
{

    [JsonPropertyName("read_count_normalized")]
    public ulong? Read_count_normalized { get; set; } = default!;


    [JsonPropertyName("read_size_bytes")]
    public ulong? Read_size_bytes { get; set; } = default!;


    [JsonPropertyName("write_count_normalized")]
    public ulong? Write_count_normalized { get; set; } = default!;


    [JsonPropertyName("write_size_bytes")]
    public ulong? Write_size_bytes { get; set; } = default!;


}