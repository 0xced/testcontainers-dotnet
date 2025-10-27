namespace DockerEngine;

/// <summary>
/// Response for a successful container-update.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerUpdateResponse
{
    /// <summary>
    /// Warnings encountered when updating the container.
    /// </summary>

    [JsonPropertyName("Warnings")]
    public ICollection<string>? Warnings { get; set; } = default!;


}