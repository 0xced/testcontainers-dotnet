using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// ManagerStatus represents the status of a manager.
/// <br/>
/// <br/>It provides the current status of a node's manager component, if the node
/// <br/>is a manager.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ManagerStatus
{

    [JsonPropertyName("Leader")]
    public bool? Leader { get; set; } = false;


    [JsonPropertyName("Reachability")]
    [JsonConverter(typeof(JsonEnumMemberConverter<Reachability>))]
    public Reachability? Reachability { get; set; } = default!;

    /// <summary>
    /// The IP address and port at which the manager is reachable.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Addr")]
    public string? Addr { get; set; } = default!;


}