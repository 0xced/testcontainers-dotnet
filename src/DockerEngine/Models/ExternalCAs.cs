using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ExternalCAs
{
    /// <summary>
    /// Protocol for communication with the external CA (currently
    /// <br/>only `cfssl` is supported).
    /// <br/>
    /// </summary>

    [JsonPropertyName("Protocol")]
    [JsonConverter(typeof(JsonEnumMemberConverter<ExternalCAsProtocol>))]
    public ExternalCAsProtocol? Protocol { get; set; } = DockerEngine.ExternalCAsProtocol.Cfssl;

    /// <summary>
    /// URL where certificate signing requests should be sent.
    /// <br/>
    /// </summary>

    [JsonPropertyName("URL")]
    public string? URL { get; set; } = default!;

    /// <summary>
    /// An object with key/value pairs that are interpreted as
    /// <br/>protocol-specific options for the external CA driver.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Options")]
    public System.Collections.Generic.IDictionary<string, string>? Options { get; set; } = default!;

    /// <summary>
    /// The root CA certificate (in PEM format) this external CA uses
    /// <br/>to issue TLS certificates (assumed to be to the current swarm
    /// <br/>root CA certificate if not provided).
    /// <br/>
    /// </summary>

    [JsonPropertyName("CACert")]
    public string? CACert { get; set; } = default!;


}