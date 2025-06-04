namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class SecretSpec
{
    /// <summary>
    /// User-defined name of the secret.
    /// </summary>

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;

    /// <summary>
    /// User-defined key/value metadata.
    /// </summary>

    [JsonPropertyName("Labels")]
    public IDictionary<string, string>? Labels { get; set; } = default!;

    /// <summary>
    /// Data is the data to store as a secret, formatted as a Base64-url-safe-encoded
    /// <br/>([RFC 4648](https://tools.ietf.org/html/rfc4648#section-5)) string.
    /// <br/>It must be empty if the Driver field is set, in which case the data is
    /// <br/>loaded from an external secret store. The maximum allowed size is 500KB,
    /// <br/>as defined in [MaxSecretSize](https://pkg.go.dev/github.com/moby/swarmkit/v2@v2.0.0-20250103191802-8c1959736554/api/validation#MaxSecretSize).
    /// <br/>
    /// <br/>This field is only used to _create_ a secret, and is not returned by
    /// <br/>other endpoints.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Data")]
    public string? Data { get; set; } = default!;

    /// <summary>
    /// Name of the secrets driver used to fetch the secret's value from an
    /// <br/>external secret store.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Driver")]
    public Driver? Driver { get; set; } = default!;

    /// <summary>
    /// Templating driver, if applicable
    /// <br/>
    /// <br/>Templating controls whether and how to evaluate the config payload as
    /// <br/>a template. If no driver is set, no templating is used.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Templating")]
    public Driver? Templating { get; set; } = default!;


}