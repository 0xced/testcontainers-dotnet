using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ExecInspectResponse
{

    [JsonPropertyName("CanRemove")]
    public bool? CanRemove { get; set; } = default!;


    [JsonPropertyName("DetachKeys")]
    public string? DetachKeys { get; set; } = default!;


    [JsonPropertyName("ID")]
    public string? ID { get; set; } = default!;


    [JsonPropertyName("Running")]
    public bool? Running { get; set; } = default!;


    [JsonPropertyName("ExitCode")]
    public int? ExitCode { get; set; } = default!;


    [JsonPropertyName("ProcessConfig")]
    public ProcessConfig? ProcessConfig { get; set; } = default!;


    [JsonPropertyName("OpenStdin")]
    public bool? OpenStdin { get; set; } = default!;


    [JsonPropertyName("OpenStderr")]
    public bool? OpenStderr { get; set; } = default!;


    [JsonPropertyName("OpenStdout")]
    public bool? OpenStdout { get; set; } = default!;


    [JsonPropertyName("ContainerID")]
    public string? ContainerID { get; set; } = default!;

    /// <summary>
    /// The system process ID for the exec process.
    /// </summary>

    [JsonPropertyName("Pid")]
    public int? Pid { get; set; } = default!;


}