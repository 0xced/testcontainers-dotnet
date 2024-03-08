using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LogConfig
{

    [JsonPropertyName("Type")]
    [JsonConverter(typeof(JsonEnumMemberConverter<LogConfigType>))]
    public LogConfigType? Type { get; set; } = default!;


    [JsonPropertyName("Config")]
    public System.Collections.Generic.IDictionary<string, string>? Config { get; set; } = default!;


}