namespace DockerEngine;

/// <summary>
/// RegistryServiceConfig stores daemon registry services configuration.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class RegistryServiceConfig
{
    /// <summary>
    /// List of IP ranges of insecure registries, using the CIDR syntax
    /// <br/>([RFC 4632](https://tools.ietf.org/html/4632)). Insecure registries
    /// <br/>accept un-encrypted (HTTP) and/or untrusted (HTTPS with certificates
    /// <br/>from unknown CAs) communication.
    /// <br/>
    /// <br/>By default, local registries (`::1/128` and `127.0.0.0/8`) are configured as
    /// <br/>insecure. All other registries are secure. Communicating with an
    /// <br/>insecure registry is not possible if the daemon assumes that registry
    /// <br/>is secure.
    /// <br/>
    /// <br/>This configuration override this behavior, insecure communication with
    /// <br/>registries whose resolved IP address is within the subnet described by
    /// <br/>the CIDR syntax.
    /// <br/>
    /// <br/>Registries can also be marked insecure by hostname. Those registries
    /// <br/>are listed under `IndexConfigs` and have their `Secure` field set to
    /// <br/>`false`.
    /// <br/>
    /// <br/>&gt; **Warning**: Using this option can be useful when running a local
    /// <br/>&gt; registry, but introduces security vulnerabilities. This option
    /// <br/>&gt; should therefore ONLY be used for testing purposes. For increased
    /// <br/>&gt; security, users should add their CA to their system's list of trusted
    /// <br/>&gt; CAs instead of enabling this option.
    /// <br/>
    /// </summary>

    [JsonPropertyName("InsecureRegistryCIDRs")]
    public ICollection<string>? InsecureRegistryCIDRs { get; set; } = default!;


    [JsonPropertyName("IndexConfigs")]
    public IDictionary<string, IndexInfo?>? IndexConfigs { get; set; } = default!;

    /// <summary>
    /// List of registry URLs that act as a mirror for the official
    /// <br/>(`docker.io`) registry.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Mirrors")]
    public ICollection<string>? Mirrors { get; set; } = default!;


}