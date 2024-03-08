using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateImageInfo
{

    [JsonPropertyName("id")]
    public string? Id { get; set; } = default!;


    [JsonPropertyName("error")]
    public string? Error { get; set; } = default!;


    [JsonPropertyName("errorDetail")]
    public ErrorDetail? ErrorDetail { get; set; } = default!;


    [JsonPropertyName("status")]
    public string? Status { get; set; } = default!;


    [JsonPropertyName("progress")]
    public string? Progress { get; set; } = default!;


    [JsonPropertyName("progressDetail")]
    public ProgressDetail? ProgressDetail { get; set; } = default!;


}