using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ImageSearchResponseItem
{

    [JsonPropertyName("description")]
    public string? Description { get; set; } = default!;


    [JsonPropertyName("is_official")]
    public bool? Is_official { get; set; } = default!;

    /// <summary>
    /// Whether this repository has automated builds enabled.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Deprecated**: This field is deprecated and will always
    /// <br/>&gt; be "false" in future.
    /// <br/>
    /// </summary>

    [JsonPropertyName("is_automated")]
    public bool? Is_automated { get; set; } = default!;


    [JsonPropertyName("name")]
    public string? Name { get; set; } = default!;


    [JsonPropertyName("star_count")]
    public int? Star_count { get; set; } = default!;


}