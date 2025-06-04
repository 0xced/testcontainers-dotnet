namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
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
    public ICollection<int>? ConsoleSize { get; set; } = default!;


}