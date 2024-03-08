using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DockerTask
{
    /// <summary>
    /// The ID of the task.
    /// </summary>

    [JsonPropertyName("ID")]
    public string? ID { get; set; } = default!;


    [JsonPropertyName("Version")]
    public ObjectVersion? Version { get; set; } = default!;


    [JsonPropertyName("CreatedAt")]
    public string? CreatedAt { get; set; } = default!;


    [JsonPropertyName("UpdatedAt")]
    public string? UpdatedAt { get; set; } = default!;

    /// <summary>
    /// Name of the task.
    /// </summary>

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;

    /// <summary>
    /// User-defined key/value metadata.
    /// </summary>

    [JsonPropertyName("Labels")]
    public System.Collections.Generic.IDictionary<string, string>? Labels { get; set; } = default!;


    [JsonPropertyName("Spec")]
    public TaskSpec? Spec { get; set; } = default!;

    /// <summary>
    /// The ID of the service this task is part of.
    /// </summary>

    [JsonPropertyName("ServiceID")]
    public string? ServiceID { get; set; } = default!;


    [JsonPropertyName("Slot")]
    public int? Slot { get; set; } = default!;

    /// <summary>
    /// The ID of the node that this task is on.
    /// </summary>

    [JsonPropertyName("NodeID")]
    public string? NodeID { get; set; } = default!;


    [JsonPropertyName("AssignedGenericResources")]
    public GenericResources? AssignedGenericResources { get; set; } = default!;


    [JsonPropertyName("Status")]
    public TaskStatus? Status { get; set; } = default!;


    [JsonPropertyName("DesiredState")]
    [JsonConverter(typeof(JsonEnumMemberConverter<TaskState>))]
    public TaskState? DesiredState { get; set; } = default!;

    /// <summary>
    /// If the Service this Task belongs to is a job-mode service, contains
    /// <br/>the JobIteration of the Service this Task was created for. Absent if
    /// <br/>the Task was created for a Replicated or Global Service.
    /// <br/>
    /// </summary>

    [JsonPropertyName("JobIteration")]
    public ObjectVersion? JobIteration { get; set; } = default!;


}