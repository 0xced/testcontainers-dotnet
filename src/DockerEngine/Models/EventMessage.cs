using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// EventMessage represents the information an event contains.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EventMessage
{
    /// <summary>
    /// The type of object emitting the event
    /// </summary>

    [JsonPropertyName("Type")]
    [JsonConverter(typeof(JsonEnumMemberConverter<EventMessageType>))]
    public EventMessageType? Type { get; set; } = default!;

    /// <summary>
    /// The type of event
    /// </summary>

    [JsonPropertyName("Action")]
    public string? Action { get; set; } = default!;


    [JsonPropertyName("Actor")]
    public EventActor? Actor { get; set; } = default!;

    /// <summary>
    /// Scope of the event. Engine events are `local` scope. Cluster (Swarm)
    /// <br/>events are `swarm` scope.
    /// <br/>
    /// </summary>

    [JsonPropertyName("scope")]
    [JsonConverter(typeof(JsonEnumMemberConverter<EventMessageScope>))]
    public EventMessageScope? Scope { get; set; } = default!;

    /// <summary>
    /// Timestamp of event
    /// </summary>

    [JsonPropertyName("time")]
    public long? Time { get; set; } = default!;

    /// <summary>
    /// Timestamp of event, with nanosecond accuracy
    /// </summary>

    [JsonPropertyName("timeNano")]
    public long? TimeNano { get; set; } = default!;


}