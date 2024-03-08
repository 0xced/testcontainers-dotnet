using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// container waiting error, if any
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerWaitExitError
{
    /// <summary>
    /// Details of an error
    /// </summary>

    [JsonPropertyName("Message")]
    public string? Message { get; set; } = default!;


}