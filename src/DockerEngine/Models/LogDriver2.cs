namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class LogDriver2
{
    /// <summary>
    /// The log driver to use as a default for new tasks.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;

    /// <summary>
    /// Driver-specific options for the selected log driver, specified
    /// <br/>as key/value pairs.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Options")]
    public IDictionary<string, string>? Options { get; set; } = default!;


}