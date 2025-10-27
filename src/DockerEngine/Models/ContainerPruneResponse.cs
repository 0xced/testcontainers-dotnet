namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerPruneResponse
{
    /// <summary>
    /// Container IDs that were deleted
    /// </summary>

    [JsonPropertyName("ContainersDeleted")]
    public ICollection<string>? ContainersDeleted { get; set; } = default!;

    /// <summary>
    /// Disk space reclaimed in bytes
    /// </summary>

    [JsonPropertyName("SpaceReclaimed")]
    public long? SpaceReclaimed { get; set; } = default!;


}