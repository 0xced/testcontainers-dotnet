using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Dispatcher
{
    /// <summary>
    /// The delay for an agent to send a heartbeat to the dispatcher.
    /// <br/>
    /// </summary>

    [JsonPropertyName("HeartbeatPeriod")]
    public long? HeartbeatPeriod { get; set; } = default!;


}