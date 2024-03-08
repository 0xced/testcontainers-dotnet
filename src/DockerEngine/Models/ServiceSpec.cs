using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// User modifiable configuration for a service.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ServiceSpec
{
    /// <summary>
    /// Name of the service.
    /// </summary>

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;

    /// <summary>
    /// User-defined key/value metadata.
    /// </summary>

    [JsonPropertyName("Labels")]
    public IDictionary<string, string>? Labels { get; set; } = default!;


    [JsonPropertyName("TaskTemplate")]
    public TaskSpec? TaskTemplate { get; set; } = default!;

    /// <summary>
    /// Scheduling mode for the service.
    /// </summary>

    [JsonPropertyName("Mode")]
    public Mode? Mode { get; set; } = default!;

    /// <summary>
    /// Specification for the update strategy of the service.
    /// </summary>

    [JsonPropertyName("UpdateConfig")]
    public UpdateConfig? UpdateConfig { get; set; } = default!;

    /// <summary>
    /// Specification for the rollback strategy of the service.
    /// </summary>

    [JsonPropertyName("RollbackConfig")]
    public RollbackConfig? RollbackConfig { get; set; } = default!;

    /// <summary>
    /// Specifies which networks the service should attach to.
    /// <br/>
    /// <br/>Deprecated: This field is deprecated since v1.44. The Networks field in TaskSpec should be used instead.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Networks")]
    public ICollection<NetworkAttachmentConfig>? Networks { get; set; } = default!;


    [JsonPropertyName("EndpointSpec")]
    public EndpointSpec? EndpointSpec { get; set; } = default!;


}