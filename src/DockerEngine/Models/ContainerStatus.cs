using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// represents the status of a container.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerStatus
{

    [JsonPropertyName("ContainerID")]
    public string? ContainerID { get; set; } = default!;


    [JsonPropertyName("PID")]
    public int? PID { get; set; } = default!;


    [JsonPropertyName("ExitCode")]
    public int? ExitCode { get; set; } = default!;


}