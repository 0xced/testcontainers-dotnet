using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Properties that can be configured to access and load balance a service.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EndpointSpec
{
    /// <summary>
    /// The mode of resolution to use for internal load balancing between tasks.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Mode")]
    [JsonConverter(typeof(JsonEnumMemberConverter<EndpointSpecMode>))]
    public EndpointSpecMode? Mode { get; set; } = DockerEngine.EndpointSpecMode.Vip;

    /// <summary>
    /// List of exposed ports that this service is accessible on from the
    /// <br/>outside. Ports can only be provided if `vip` resolution mode is used.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Ports")]
    public ICollection<EndpointPortConfig>? Ports { get; set; } = default!;


}