using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class UnlockKeyResponse
{
    /// <summary>
    /// The swarm's unlock key.
    /// </summary>

    [JsonPropertyName("UnlockKey")]
    public string? UnlockKey { get; set; } = default!;


}