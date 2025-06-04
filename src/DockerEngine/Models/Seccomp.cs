using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class Seccomp
{

    [JsonPropertyName("Mode")]
    [JsonConverter(typeof(JsonEnumMemberConverter<SeccompMode>))]
    public SeccompMode? Mode { get; set; } = default!;

    /// <summary>
    /// The custom seccomp profile as a json object
    /// </summary>

    [JsonPropertyName("Profile")]
    public string? Profile { get; set; } = default!;


}