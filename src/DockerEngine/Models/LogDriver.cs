using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class LogDriver
{

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;


    [JsonPropertyName("Options")]
    public IDictionary<string, string>? Options { get; set; } = default!;


}