using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
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
    public System.Collections.Generic.IDictionary<string, string>? Labels { get; set; } = default!;

    /// <summary>
    /// Base64-url-safe-encoded ([RFC 4648](https://tools.ietf.org/html/rfc4648#section-5))
    /// <br/>config data.
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