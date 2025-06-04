namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class Response
{
    /// <summary>
    /// The status of the authentication
    /// </summary>

    [JsonPropertyName("Status")]
    public string Status { get; set; } = default!;

    /// <summary>
    /// An opaque token used to authenticate a user after a successful login
    /// </summary>

    [JsonPropertyName("IdentityToken")]
    public string? IdentityToken { get; set; } = default!;


}