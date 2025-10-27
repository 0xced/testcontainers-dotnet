namespace DockerEngine;

/// <summary>
/// The config-only network source to provide the configuration for
/// <br/>this network.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class ConfigReference
{
    /// <summary>
    /// The name of the config-only network that provides the network's
    /// <br/>configuration. The specified network must be an existing config-only
    /// <br/>network. Only network names are allowed, not network IDs.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Network")]
    public string? Network { get; set; } = default!;


}