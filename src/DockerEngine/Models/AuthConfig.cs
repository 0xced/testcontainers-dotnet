namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class AuthConfig
{

    [JsonPropertyName("username")]
    public string? Username { get; set; } = default!;


    [JsonPropertyName("password")]
    public string? Password { get; set; } = default!;

    /// <summary>
    /// Email is an optional value associated with the username.
    /// <br/>
    /// <br/>&gt; **Deprecated**: This field is deprecated since docker 1.11 (API v1.23) and will be removed in a future release.
    /// <br/>
    /// </summary>

    [JsonPropertyName("email")]
    public string? Email { get; set; } = default!;


    [JsonPropertyName("serveraddress")]
    public string? Serveraddress { get; set; } = default!;


}