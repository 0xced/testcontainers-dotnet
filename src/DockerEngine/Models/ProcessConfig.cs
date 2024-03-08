using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ProcessConfig
{

    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; } = default!;


    [JsonPropertyName("user")]
    public string? User { get; set; } = default!;


    [JsonPropertyName("tty")]
    public bool? Tty { get; set; } = default!;


    [JsonPropertyName("entrypoint")]
    public string? Entrypoint { get; set; } = default!;


    [JsonPropertyName("arguments")]
    public ICollection<string>? Arguments { get; set; } = default!;


}