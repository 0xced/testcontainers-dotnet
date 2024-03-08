using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Service
{

    [JsonPropertyName("ID")]
    public string? ID { get; set; } = default!;


    [JsonPropertyName("Version")]
    public ObjectVersion? Version { get; set; } = default!;


    [JsonPropertyName("CreatedAt")]
    public string? CreatedAt { get; set; } = default!;


    [JsonPropertyName("UpdatedAt")]
    public string? UpdatedAt { get; set; } = default!;


    [JsonPropertyName("Spec")]
    public ServiceSpec? Spec { get; set; } = default!;


    [JsonPropertyName("Endpoint")]
    public Endpoint? Endpoint { get; set; } = default!;

    /// <summary>
    /// The status of a service update.
    /// </summary>

    [JsonPropertyName("UpdateStatus")]
    public UpdateStatus? UpdateStatus { get; set; } = default!;

    /// <summary>
    /// The status of the service's tasks. Provided only when requested as
    /// <br/>part of a ServiceList operation.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ServiceStatus")]
    public ServiceStatus? ServiceStatus { get; set; } = default!;

    /// <summary>
    /// The status of the service when it is in one of ReplicatedJob or
    /// <br/>GlobalJob modes. Absent on Replicated and Global mode services. The
    /// <br/>JobIteration is an ObjectVersion, but unlike the Service's version,
    /// <br/>does not need to be sent with an update request.
    /// <br/>
    /// </summary>

    [JsonPropertyName("JobStatus")]
    public JobStatus? JobStatus { get; set; } = default!;


}