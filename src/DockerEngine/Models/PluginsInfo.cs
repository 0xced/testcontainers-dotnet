using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Available plugins per type.
/// <br/>
/// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
/// <br/>
/// <br/>&gt; **Note**: Only unmanaged (V1) plugins are included in this list.
/// <br/>&gt; V1 plugins are "lazily" loaded, and are not returned in this list
/// <br/>&gt; if there is no resource using the plugin.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PluginsInfo
{
    /// <summary>
    /// Names of available volume-drivers, and network-driver plugins.
    /// </summary>

    [JsonPropertyName("Volume")]
    public ICollection<string>? Volume { get; set; } = default!;

    /// <summary>
    /// Names of available network-drivers, and network-driver plugins.
    /// </summary>

    [JsonPropertyName("Network")]
    public ICollection<string>? Network { get; set; } = default!;

    /// <summary>
    /// Names of available authorization plugins.
    /// </summary>

    [JsonPropertyName("Authorization")]
    public ICollection<string>? Authorization { get; set; } = default!;

    /// <summary>
    /// Names of available logging-drivers, and logging-driver plugins.
    /// </summary>

    [JsonPropertyName("Log")]
    public ICollection<string>? Log { get; set; } = default!;


}