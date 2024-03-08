using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Metadata
{
    /// <summary>
    /// Date and time at which the image was last tagged in
    /// <br/>[RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) format with nano-seconds.
    /// <br/>
    /// <br/>This information is only available if the image was tagged locally,
    /// <br/>and omitted otherwise.
    /// <br/>
    /// </summary>

    [JsonPropertyName("LastTagTime")]
    public string? LastTagTime { get; set; } = default!;


}