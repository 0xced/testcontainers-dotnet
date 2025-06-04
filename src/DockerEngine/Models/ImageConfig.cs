namespace DockerEngine;

/// <summary>
/// Configuration of the image. These fields are used as defaults
/// <br/>when starting a container from the image.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class ImageConfig
{
    /// <summary>
    /// The hostname to use for the container, as a valid RFC 1123 hostname.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: this field is always empty and must not be used.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Hostname")]
    public string? Hostname { get; set; } = default!;

    /// <summary>
    /// The domain name to use for the container.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: this field is always empty and must not be used.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Domainname")]
    public string? Domainname { get; set; } = default!;

    /// <summary>
    /// The user that commands are run as inside the container.
    /// </summary>

    [JsonPropertyName("User")]
    public string? User { get; set; } = default!;

    /// <summary>
    /// Whether to attach to `stdin`.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: this field is always false and must not be used.
    /// <br/>
    /// </summary>

    [JsonPropertyName("AttachStdin")]
    public bool? AttachStdin { get; set; } = false;

    /// <summary>
    /// Whether to attach to `stdout`.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: this field is always false and must not be used.
    /// <br/>
    /// </summary>

    [JsonPropertyName("AttachStdout")]
    public bool? AttachStdout { get; set; } = false;

    /// <summary>
    /// Whether to attach to `stderr`.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: this field is always false and must not be used.
    /// <br/>
    /// </summary>

    [JsonPropertyName("AttachStderr")]
    public bool? AttachStderr { get; set; } = false;

    /// <summary>
    /// An object mapping ports to an empty object in the form:
    /// <br/>
    /// <br/>`{"&lt;port&gt;/&lt;tcp|udp|sctp&gt;": {}}`
    /// <br/>
    /// </summary>

    [JsonPropertyName("ExposedPorts")]
    public IDictionary<string, Anonymous5>? ExposedPorts { get; set; } = default!;

    /// <summary>
    /// Attach standard streams to a TTY, including `stdin` if it is not closed.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: this field is always false and must not be used.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Tty")]
    public bool? Tty { get; set; } = false;

    /// <summary>
    /// Open `stdin`
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: this field is always false and must not be used.
    /// <br/>
    /// </summary>

    [JsonPropertyName("OpenStdin")]
    public bool? OpenStdin { get; set; } = false;

    /// <summary>
    /// Close `stdin` after one attached client disconnects.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: this field is always false and must not be used.
    /// <br/>
    /// </summary>

    [JsonPropertyName("StdinOnce")]
    public bool? StdinOnce { get; set; } = false;

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
    /// The name (or reference) of the image to use when creating the container,
    /// <br/>or which was used when the container was created.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: this field is always empty and must not be used.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Image")]
    public string? Image { get; set; } = "";

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
    /// Disable networking for the container.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: this field is always omitted and must not be used.
    /// <br/>
    /// </summary>

    [JsonPropertyName("NetworkDisabled")]
    public bool? NetworkDisabled { get; set; } = false;

    /// <summary>
    /// MAC address of the container.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Deprecated**: this field is deprecated in API v1.44 and up. It is always omitted.
    /// <br/>
    /// </summary>

    [JsonPropertyName("MacAddress")]
    public string? MacAddress { get; set; } = "";

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
    /// Timeout to stop a container in seconds.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: this field is always omitted and must not be used.
    /// <br/>
    /// </summary>

    [JsonPropertyName("StopTimeout")]
    public int? StopTimeout { get; set; } = 10;

    /// <summary>
    /// Shell for when `RUN`, `CMD`, and `ENTRYPOINT` uses a shell.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Shell")]
    public ICollection<string>? Shell { get; set; } = default!;


}