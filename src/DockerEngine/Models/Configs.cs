using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Configs
{
    /// <summary>
    /// File represents a specific target that is backed by a file.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: `Configs.File` and `Configs.Runtime` are mutually exclusive
    /// <br/>
    /// </summary>

    [JsonPropertyName("File")]
    public File2? File { get; set; } = default!;

    /// <summary>
    /// Runtime represents a target that is not mounted into the
    /// <br/>container but is used by the task
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: `Configs.File` and `Configs.Runtime` are mutually
    /// <br/>&gt; exclusive
    /// <br/>
    /// </summary>

    [JsonPropertyName("Runtime")]
    public object? Runtime { get; set; } = default!;

    /// <summary>
    /// ConfigID represents the ID of the specific config that we're
    /// <br/>referencing.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ConfigID")]
    public string? ConfigID { get; set; } = default!;

    /// <summary>
    /// ConfigName is the name of the config that this references,
    /// <br/>but this is just provided for lookup/display purposes. The
    /// <br/>config in the reference will be identified by its ID.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ConfigName")]
    public string? ConfigName { get; set; } = default!;


}