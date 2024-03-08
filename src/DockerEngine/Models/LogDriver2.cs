using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LogDriver2
{
    /// <summary>
    /// The log driver to use as a default for new tasks.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;

    /// <summary>
    /// Driver-specific options for the selectd log driver, specified
    /// <br/>as key/value pairs.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Options")]
    public System.Collections.Generic.IDictionary<string, string>? Options { get; set; } = default!;


}