using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ExecStartConfig
{
    /// <summary>
    /// Detach from the command.
    /// </summary>

    [JsonPropertyName("Detach")]
    public bool? Detach { get; set; } = default!;

    /// <summary>
    /// Allocate a pseudo-TTY.
    /// </summary>

    [JsonPropertyName("Tty")]
    public bool? Tty { get; set; } = default!;

    /// <summary>
    /// Initial console size, as an `[height, width]` array.
    /// </summary>

    [JsonPropertyName("ConsoleSize")]
    public System.Collections.Generic.ICollection<int>? ConsoleSize { get; set; } = default!;


}