namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class LogConfig
{
    /// <summary>
    /// Name of the logging driver used for the container or "none"
    /// <br/>if logging is disabled.
    /// </summary>

    [JsonPropertyName("Type")]
    [JsonConverter(typeof(JsonEnumMemberConverter<LogConfigType>))]
    public LogConfigType? Type { get; set; } = default!;

    /// <summary>
    /// Driver-specific configuration options for the logging driver.
    /// </summary>

    [JsonPropertyName("Config")]
    public IDictionary<string, string>? Config { get; set; } = default!;


}