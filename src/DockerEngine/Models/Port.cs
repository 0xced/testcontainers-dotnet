using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// An open port on a container
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Port
{
    /// <summary>
    /// Host IP address that the container's port is mapped to
    /// </summary>

    [JsonPropertyName("IP")]
    public string? IP { get; set; } = default!;

    /// <summary>
    /// Port on the container
    /// </summary>

    [JsonPropertyName("PrivatePort")]
    public int PrivatePort { get; set; } = default!;

    /// <summary>
    /// Port exposed on the host
    /// </summary>

    [JsonPropertyName("PublicPort")]
    public int? PublicPort { get; set; } = default!;


    [JsonPropertyName("Type")]
    [JsonConverter(typeof(JsonEnumMemberConverter<PortType>))]
    public PortType Type { get; set; } = default!;


}