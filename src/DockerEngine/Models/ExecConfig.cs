using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ExecConfig
{
    /// <summary>
    /// Attach to `stdin` of the exec command.
    /// </summary>

    [JsonPropertyName("AttachStdin")]
    public bool? AttachStdin { get; set; } = default!;

    /// <summary>
    /// Attach to `stdout` of the exec command.
    /// </summary>

    [JsonPropertyName("AttachStdout")]
    public bool? AttachStdout { get; set; } = default!;

    /// <summary>
    /// Attach to `stderr` of the exec command.
    /// </summary>

    [JsonPropertyName("AttachStderr")]
    public bool? AttachStderr { get; set; } = default!;

    /// <summary>
    /// Initial console size, as an `[height, width]` array.
    /// </summary>

    [JsonPropertyName("ConsoleSize")]
    public ICollection<int>? ConsoleSize { get; set; } = default!;

    /// <summary>
    /// Override the key sequence for detaching a container. Format is
    /// <br/>a single character `[a-Z]` or `ctrl-&lt;value&gt;` where `&lt;value&gt;`
    /// <br/>is one of: `a-z`, `@`, `^`, `[`, `,` or `_`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("DetachKeys")]
    public string? DetachKeys { get; set; } = default!;

    /// <summary>
    /// Allocate a pseudo-TTY.
    /// </summary>

    [JsonPropertyName("Tty")]
    public bool? Tty { get; set; } = default!;

    /// <summary>
    /// A list of environment variables in the form `["VAR=value", ...]`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Env")]
    public ICollection<string>? Env { get; set; } = default!;

    /// <summary>
    /// Command to run, as a string or array of strings.
    /// </summary>

    [JsonPropertyName("Cmd")]
    public ICollection<string>? Cmd { get; set; } = default!;

    /// <summary>
    /// Runs the exec process with extended privileges.
    /// </summary>

    [JsonPropertyName("Privileged")]
    public bool? Privileged { get; set; } = false;

    /// <summary>
    /// The user, and optionally, group to run the exec process inside
    /// <br/>the container. Format is one of: `user`, `user:group`, `uid`,
    /// <br/>or `uid:gid`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("User")]
    public string? User { get; set; } = default!;

    /// <summary>
    /// The working directory for the exec process inside the container.
    /// <br/>
    /// </summary>

    [JsonPropertyName("WorkingDir")]
    public string? WorkingDir { get; set; } = default!;


}