using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// IndexInfo contains information about a registry.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class IndexInfo
{
    /// <summary>
    /// Name of the registry, such as "docker.io".
    /// <br/>
    /// </summary>

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;

    /// <summary>
    /// List of mirrors, expressed as URIs.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Mirrors")]
    public System.Collections.Generic.ICollection<string>? Mirrors { get; set; } = default!;

    /// <summary>
    /// Indicates if the registry is part of the list of insecure
    /// <br/>registries.
    /// <br/>
    /// <br/>If `false`, the registry is insecure. Insecure registries accept
    /// <br/>un-encrypted (HTTP) and/or untrusted (HTTPS with certificates from
    /// <br/>unknown CAs) communication.
    /// <br/>
    /// <br/>&gt; **Warning**: Insecure registries can be useful when running a local
    /// <br/>&gt; registry. However, because its use creates security vulnerabilities
    /// <br/>&gt; it should ONLY be enabled for testing purposes. For increased
    /// <br/>&gt; security, users should add their CA to their system's list of
    /// <br/>&gt; trusted CAs instead of enabling this option.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Secure")]
    public bool? Secure { get; set; } = default!;

    /// <summary>
    /// Indicates whether this is an official registry (i.e., Docker Hub / docker.io)
    /// <br/>
    /// </summary>

    [JsonPropertyName("Official")]
    public bool? Official { get; set; } = default!;


}