using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Configuration for a container that is portable between hosts.
/// <br/>
/// <br/>When used as `ContainerConfig` field in an image, `ContainerConfig` is an
/// <br/>optional field containing the configuration of the container that was last
/// <br/>committed when creating the image.
/// <br/>
/// <br/>Previous versions of Docker builder used this field to store build cache,
/// <br/>and it is not in active use anymore.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerConfig
{
    /// <summary>
    /// The hostname to use for the container, as a valid RFC 1123 hostname.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Hostname")]
    public string? Hostname { get; set; } = default!;

    /// <summary>
    /// The domain name to use for the container.
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
    /// </summary>

    [JsonPropertyName("AttachStdin")]
    public bool? AttachStdin { get; set; } = false;

    /// <summary>
    /// Whether to attach to `stdout`.
    /// </summary>

    [JsonPropertyName("AttachStdout")]
    public bool? AttachStdout { get; set; } = true;

    /// <summary>
    /// Whether to attach to `stderr`.
    /// </summary>

    [JsonPropertyName("AttachStderr")]
    public bool? AttachStderr { get; set; } = true;

    /// <summary>
    /// An object mapping ports to an empty object in the form:
    /// <br/>
    /// <br/>`{"&lt;port&gt;/&lt;tcp|udp|sctp&gt;": {}}`
    /// <br/>
    /// </summary>

    [JsonPropertyName("ExposedPorts")]
    public IDictionary<string, Anonymous3>? ExposedPorts { get; set; } = default!;

    /// <summary>
    /// Attach standard streams to a TTY, including `stdin` if it is not closed.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Tty")]
    public bool? Tty { get; set; } = false;

    /// <summary>
    /// Open `stdin`
    /// </summary>

    [JsonPropertyName("OpenStdin")]
    public bool? OpenStdin { get; set; } = false;

    /// <summary>
    /// Close `stdin` after one attached client disconnects
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
    /// </summary>

    [JsonPropertyName("Image")]
    public string? Image { get; set; } = default!;

    /// <summary>
    /// An object mapping mount point paths inside the container to empty
    /// <br/>objects.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Volumes")]
    public IDictionary<string, Anonymous4>? Volumes { get; set; } = default!;

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
    /// </summary>

    [JsonPropertyName("NetworkDisabled")]
    public bool? NetworkDisabled { get; set; } = default!;

    /// <summary>
    /// MAC address of the container.
    /// <br/>
    /// <br/>Deprecated: this field is deprecated in API v1.44 and up. Use EndpointSettings.MacAddress instead.
    /// <br/>
    /// </summary>

    [JsonPropertyName("MacAddress")]
    public string? MacAddress { get; set; } = default!;

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