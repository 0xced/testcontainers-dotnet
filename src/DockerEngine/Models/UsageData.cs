using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UsageData
{
    /// <summary>
    /// Amount of disk space used by the volume (in bytes). This information
    /// <br/>is only available for volumes created with the `"local"` volume
    /// <br/>driver. For volumes created with other volume drivers, this field
    /// <br/>is set to `-1` ("not available")
    /// <br/>
    /// </summary>

    [JsonPropertyName("Size")]
    public long Size { get; set; } = -1L;

    /// <summary>
    /// The number of containers referencing this volume. This field
    /// <br/>is set to `-1` if the reference-count is not available.
    /// <br/>
    /// </summary>

    [JsonPropertyName("RefCount")]
    public long RefCount { get; set; } = -1L;


}