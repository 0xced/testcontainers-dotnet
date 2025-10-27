namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class VolumePruneResponse
{
    /// <summary>
    /// Volumes that were deleted
    /// </summary>

    [JsonPropertyName("VolumesDeleted")]
    public ICollection<string>? VolumesDeleted { get; set; } = default!;

    /// <summary>
    /// Disk space reclaimed in bytes
    /// </summary>

    [JsonPropertyName("SpaceReclaimed")]
    public long? SpaceReclaimed { get; set; } = default!;


}