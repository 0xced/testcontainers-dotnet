using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class NetworkPruneResponse
{
    /// <summary>
    /// Networks that were deleted
    /// </summary>

    [JsonPropertyName("NetworksDeleted")]
    public ICollection<string>? NetworksDeleted { get; set; } = default!;


}