namespace DockerEngine;

/// <summary>
/// Information about the daemon's firewalling configuration.
/// <br/>
/// <br/>This field is currently only used on Linux, and omitted on other platforms.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class FirewallInfo
{
    /// <summary>
    /// The name of the firewall backend driver.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Driver")]
    public string? Driver { get; set; } = default!;

    /// <summary>
    /// Information about the firewall backend, provided as
    /// <br/>"label" / "value" pairs.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: The information returned in this field, including the
    /// <br/>&gt; formatting of values and labels, should not be considered stable,
    /// <br/>&gt; and may change without notice.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Info")]
    public ICollection<ICollection<string>>? Info { get; set; } = default!;


}