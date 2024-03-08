using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CAConfig
{
    /// <summary>
    /// The duration node certificates are issued for.
    /// </summary>

    [JsonPropertyName("NodeCertExpiry")]
    public long? NodeCertExpiry { get; set; } = default!;

    /// <summary>
    /// Configuration for forwarding signing requests to an external
    /// <br/>certificate authority.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ExternalCAs")]
    public ICollection<ExternalCAs>? ExternalCAs { get; set; } = default!;

    /// <summary>
    /// The desired signing CA certificate for all swarm node TLS leaf
    /// <br/>certificates, in PEM format.
    /// <br/>
    /// </summary>

    [JsonPropertyName("SigningCACert")]
    public string? SigningCACert { get; set; } = default!;

    /// <summary>
    /// The desired signing CA key for all swarm node TLS leaf certificates,
    /// <br/>in PEM format.
    /// <br/>
    /// </summary>

    [JsonPropertyName("SigningCAKey")]
    public string? SigningCAKey { get; set; } = default!;

    /// <summary>
    /// An integer whose purpose is to force swarm to generate a new
    /// <br/>signing CA certificate and key, if none have been specified in
    /// <br/>`SigningCACert` and `SigningCAKey`
    /// <br/>
    /// </summary>

    [JsonPropertyName("ForceRotate")]
    public ulong? ForceRotate { get; set; } = default!;


}