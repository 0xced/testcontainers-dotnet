namespace DockerEngine;

/// <summary>
/// Configuration of the image. These fields are used as defaults
/// <br/>when starting a container from the image.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class ImageConfig
{
    /// <summary>
    /// The user that commands are run as inside the container.
    /// </summary>

    [JsonPropertyName("User")]
    public string? User { get; set; } = default!;

    /// <summary>
    /// An object mapping ports to an empty object in the form:
    /// <br/>
    /// <br/>`{"&lt;port&gt;/&lt;tcp|udp|sctp&gt;": {}}`
    /// <br/>
    /// </summary>

    [JsonPropertyName("ExposedPorts")]
    public IDictionary<string, Anonymous5>? ExposedPorts { get; set; } = default!;

    /// <summary>
    /// A list of environment variables to set inside the container in the
    /// <br/>form `["VAR=value", ...]`. A variable without `=` is removed from the
    /// <br/>environment, rather than to have an empty value.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Env")]
    public ICollection<string>? Env { get; set; } = default!;

    /// <summary>
    /// Command to run specified as a string or an array of strings.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Cmd")]
    public ICollection<string>? Cmd { get; set; } = default!;


    [JsonPropertyName("Healthcheck")]
    public HealthConfig? Healthcheck { get; set; } = default!;

    /// <summary>
    /// Command is already escaped (Windows only)
    /// </summary>

    [JsonPropertyName("ArgsEscaped")]
    public bool? ArgsEscaped { get; set; } = false;

    /// <summary>
    /// An object mapping mount point paths inside the container to empty
    /// <br/>objects.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Volumes")]
    public IDictionary<string, Anonymous6>? Volumes { get; set; } = default!;

    /// <summary>
    /// The working directory for commands to run in.
    /// </summary>

    [JsonPropertyName("WorkingDir")]
    public string? WorkingDir { get; set; } = default!;

    /// <summary>
    /// The entry point for the container as a string or an array of strings.
    /// <br/>
    /// <br/>If the array consists of exactly one empty string (`[""]`) then the
    /// <br/>entry point is reset to system default (i.e., the entry point used by
    /// <br/>docker when there is no `ENTRYPOINT` instruction in the `Dockerfile`).
    /// <br/>
    /// </summary>

    [JsonPropertyName("Entrypoint")]
    public ICollection<string>? Entrypoint { get; set; } = default!;

    /// <summary>
    /// `ONBUILD` metadata that were defined in the image's `Dockerfile`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("OnBuild")]
    public ICollection<string>? OnBuild { get; set; } = default!;

    /// <summary>
    /// User-defined key/value metadata.
    /// </summary>

    [JsonPropertyName("Labels")]
    public IDictionary<string, string>? Labels { get; set; } = default!;

    /// <summary>
    /// Signal to stop a container as a string or unsigned integer.
    /// <br/>
    /// </summary>

    [JsonPropertyName("StopSignal")]
    public string? StopSignal { get; set; } = default!;

    /// <summary>
    /// Shell for when `RUN`, `CMD`, and `ENTRYPOINT` uses a shell.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Shell")]
    public ICollection<string>? Shell { get; set; } = default!;


}