using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Swarm : ClusterInfo
{

    [JsonPropertyName("JoinTokens")]
    public JoinTokens? JoinTokens { get; set; } = default!;


}