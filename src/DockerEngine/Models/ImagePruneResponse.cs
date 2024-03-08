using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ImagePruneResponse
{
    /// <summary>
    /// Images that were deleted
    /// </summary>

    [JsonPropertyName("ImagesDeleted")]
    public ICollection<ImageDeleteResponseItem>? ImagesDeleted { get; set; } = default!;

    /// <summary>
    /// Disk space reclaimed in bytes
    /// </summary>

    [JsonPropertyName("SpaceReclaimed")]
    public long? SpaceReclaimed { get; set; } = default!;


}