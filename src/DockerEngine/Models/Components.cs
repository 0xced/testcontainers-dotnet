using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Components
{
    /// <summary>
    /// Name of the component
    /// <br/>
    /// </summary>

    [JsonPropertyName("Name")]
    public string Name { get; set; } = default!;

    /// <summary>
    /// Version of the component
    /// <br/>
    /// </summary>

    [JsonPropertyName("Version")]
    public string Version { get; set; } = default!;

    /// <summary>
    /// Key/value pairs of strings with additional information about the
    /// <br/>component. These values are intended for informational purposes
    /// <br/>only, and their content is not defined, and not part of the API
    /// <br/>specification.
    /// <br/>
    /// <br/>These messages can be printed by the client as information to the user.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Details")]
    public object? Details { get; set; } = default!;


}