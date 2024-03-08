using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// represents the status of a task.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TaskStatus
{

    [JsonPropertyName("Timestamp")]
    public string? Timestamp { get; set; } = default!;


    [JsonPropertyName("State")]
    [JsonConverter(typeof(JsonEnumMemberConverter<TaskState>))]
    public TaskState? State { get; set; } = default!;


    [JsonPropertyName("Message")]
    public string? Message { get; set; } = default!;


    [JsonPropertyName("Err")]
    public string? Err { get; set; } = default!;


    [JsonPropertyName("ContainerStatus")]
    public ContainerStatus? ContainerStatus { get; set; } = default!;


    [JsonPropertyName("PortStatus")]
    public PortStatus? PortStatus { get; set; } = default!;


}