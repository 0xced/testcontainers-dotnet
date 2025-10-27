namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class AttestationData
{
    /// <summary>
    /// The digest of the image manifest that this attestation is for.
    /// <br/>
    /// </summary>

    [JsonPropertyName("For")]
    public string For { get; set; } = default!;


}