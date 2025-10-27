namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class NetworkPruneResponse
{
    /// <summary>
    /// Networks that were deleted
    /// </summary>

    [JsonPropertyName("NetworksDeleted")]
    public ICollection<string>? NetworksDeleted { get; set; } = default!;


}