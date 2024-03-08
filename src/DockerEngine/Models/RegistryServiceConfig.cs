using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// RegistryServiceConfig stores daemon registry services configuration.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class RegistryServiceConfig
{
    /// <summary>
    /// List of IP ranges to which nondistributable artifacts can be pushed,
    /// <br/>using the CIDR syntax [RFC 4632](https://tools.ietf.org/html/4632).
    /// <br/>
    /// <br/>Some images (for example, Windows base images) contain artifacts
    /// <br/>whose distribution is restricted by license. When these images are
    /// <br/>pushed to a registry, restricted artifacts are not included.
    /// <br/>
    /// <br/>This configuration override this behavior, and enables the daemon to
    /// <br/>push nondistributable artifacts to all registries whose resolved IP
    /// <br/>address is within the subnet described by the CIDR syntax.
    /// <br/>
    /// <br/>This option is useful when pushing images containing
    /// <br/>nondistributable artifacts to a registry on an air-gapped network so
    /// <br/>hosts on that network can pull the images without connecting to
    /// <br/>another server.
    /// <br/>
    /// <br/>&gt; **Warning**: Nondistributable artifacts typically have restrictions
    /// <br/>&gt; on how and where they can be distributed and shared. Only use this
    /// <br/>&gt; feature to push artifacts to private registries and ensure that you
    /// <br/>&gt; are in compliance with any terms that cover redistributing
    /// <br/>&gt; nondistributable artifacts.
    /// <br/>
    /// </summary>

    [JsonPropertyName("AllowNondistributableArtifactsCIDRs")]
    public System.Collections.Generic.ICollection<string>? AllowNondistributableArtifactsCIDRs { get; set; } = default!;

    /// <summary>
    /// List of registry hostnames to which nondistributable artifacts can be
    /// <br/>pushed, using the format `&lt;hostname&gt;[:&lt;port&gt;]` or `&lt;IP address&gt;[:&lt;port&gt;]`.
    /// <br/>
    /// <br/>Some images (for example, Windows base images) contain artifacts
    /// <br/>whose distribution is restricted by license. When these images are
    /// <br/>pushed to a registry, restricted artifacts are not included.
    /// <br/>
    /// <br/>This configuration override this behavior for the specified
    /// <br/>registries.
    /// <br/>
    /// <br/>This option is useful when pushing images containing
    /// <br/>nondistributable artifacts to a registry on an air-gapped network so
    /// <br/>hosts on that network can pull the images without connecting to
    /// <br/>another server.
    /// <br/>
    /// <br/>&gt; **Warning**: Nondistributable artifacts typically have restrictions
    /// <br/>&gt; on how and where they can be distributed and shared. Only use this
    /// <br/>&gt; feature to push artifacts to private registries and ensure that you
    /// <br/>&gt; are in compliance with any terms that cover redistributing
    /// <br/>&gt; nondistributable artifacts.
    /// <br/>
    /// </summary>

    [JsonPropertyName("AllowNondistributableArtifactsHostnames")]
    public System.Collections.Generic.ICollection<string>? AllowNondistributableArtifactsHostnames { get; set; } = default!;

    /// <summary>
    /// List of IP ranges of insecure registries, using the CIDR syntax
    /// <br/>([RFC 4632](https://tools.ietf.org/html/4632)). Insecure registries
    /// <br/>accept un-encrypted (HTTP) and/or untrusted (HTTPS with certificates
    /// <br/>from unknown CAs) communication.
    /// <br/>
    /// <br/>By default, local registries (`127.0.0.0/8`) are configured as
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
    public System.Collections.Generic.ICollection<string>? InsecureRegistryCIDRs { get; set; } = default!;


    [JsonPropertyName("IndexConfigs")]
    public System.Collections.Generic.IDictionary<string, IndexInfo?>? IndexConfigs { get; set; } = default!;

    /// <summary>
    /// List of registry URLs that act as a mirror for the official
    /// <br/>(`docker.io`) registry.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Mirrors")]
    public System.Collections.Generic.ICollection<string>? Mirrors { get; set; } = default!;


}