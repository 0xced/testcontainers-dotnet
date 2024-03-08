using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Update : Resources
{

    [JsonPropertyName("RestartPolicy")]
    public RestartPolicy? RestartPolicy { get; set; } = default!;


}