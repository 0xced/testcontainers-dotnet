namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class ConfigSpec
{
    /// <summary>
    /// User-defined name of the config.
    /// </summary>

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;

    /// <summary>
    /// User-defined key/value metadata.
    /// </summary>

    [JsonPropertyName("Labels")]
    public IDictionary<string, string>? Labels { get; set; } = default!;

    /// <summary>
    /// Data is the data to store as a config, formatted as a Base64-url-safe-encoded
    /// <br/>([RFC 4648](https://tools.ietf.org/html/rfc4648#section-5)) string.
    /// <br/>The maximum allowed size is 1000KB, as defined in [MaxConfigSize](https://pkg.go.dev/github.com/moby/swarmkit/v2@v2.0.0-20250103191802-8c1959736554/manager/controlapi#MaxConfigSize).
    /// <br/>
    /// </summary>

    [JsonPropertyName("Data")]
    public string? Data { get; set; } = default!;

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