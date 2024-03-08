using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Represents an error.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ErrorResponse
{
    /// <summary>
    /// The error message.
    /// </summary>

    [JsonPropertyName("message")]
    public string Message { get; set; } = default!;


}