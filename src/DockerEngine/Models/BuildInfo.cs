namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class BuildInfo
{

    [JsonPropertyName("id")]
    public string? Id { get; set; } = default!;


    [JsonPropertyName("stream")]
    public string? Stream { get; set; } = default!;

    /// <summary>
    /// errors encountered during the operation.
    /// <br/>
    /// <br/>
    /// <br/>&gt; **Deprecated**: This field is deprecated since API v1.4, and will be omitted in a future API version. Use the information in errorDetail instead.
    /// </summary>

    [JsonPropertyName("error")]
    public string? Error { get; set; } = default!;


    [JsonPropertyName("errorDetail")]
    public ErrorDetail? ErrorDetail { get; set; } = default!;


    [JsonPropertyName("status")]
    public string? Status { get; set; } = default!;

    /// <summary>
    /// Progress is a pre-formatted presentation of progressDetail.
    /// <br/>
    /// <br/>
    /// <br/>&gt; **Deprecated**: This field is deprecated since API v1.8, and will be omitted in a future API version. Use the information in progressDetail instead.
    /// </summary>

    [JsonPropertyName("progress")]
    public string? Progress { get; set; } = default!;


    [JsonPropertyName("progressDetail")]
    public ProgressDetail? ProgressDetail { get; set; } = default!;


    [JsonPropertyName("aux")]
    public ImageID? Aux { get; set; } = default!;


}