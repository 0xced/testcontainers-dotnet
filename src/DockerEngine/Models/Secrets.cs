using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Secrets
{
    /// <summary>
    /// File represents a specific target that is backed by a file.
    /// <br/>
    /// </summary>

    [JsonPropertyName("File")]
    public File? File { get; set; } = default!;

    /// <summary>
    /// SecretID represents the ID of the specific secret that we're
    /// <br/>referencing.
    /// <br/>
    /// </summary>

    [JsonPropertyName("SecretID")]
    public string? SecretID { get; set; } = default!;

    /// <summary>
    /// SecretName is the name of the secret that this references,
    /// <br/>but this is just provided for lookup/display purposes. The
    /// <br/>secret in the reference will be identified by its ID.
    /// <br/>
    /// </summary>

    [JsonPropertyName("SecretName")]
    public string? SecretName { get; set; } = default!;


}