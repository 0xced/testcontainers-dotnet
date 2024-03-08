using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UpdateStatus
{

    [JsonPropertyName("State")]
    [JsonConverter(typeof(JsonEnumMemberConverter<UpdateStatusState>))]
    public UpdateStatusState? State { get; set; } = default!;


    [JsonPropertyName("StartedAt")]
    public string? StartedAt { get; set; } = default!;


    [JsonPropertyName("CompletedAt")]
    public string? CompletedAt { get; set; } = default!;


    [JsonPropertyName("Message")]
    public string? Message { get; set; } = default!;


}