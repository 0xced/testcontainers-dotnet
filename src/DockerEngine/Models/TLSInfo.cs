using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Information about the issuer of leaf TLS certificates and the trusted root
/// <br/>CA certificate.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TLSInfo
{
    /// <summary>
    /// The root CA certificate(s) that are used to validate leaf TLS
    /// <br/>certificates.
    /// <br/>
    /// </summary>

    [JsonPropertyName("TrustRoot")]
    public string? TrustRoot { get; set; } = default!;

    /// <summary>
    /// The base64-url-safe-encoded raw subject bytes of the issuer.
    /// </summary>

    [JsonPropertyName("CertIssuerSubject")]
    public string? CertIssuerSubject { get; set; } = default!;

    /// <summary>
    /// The base64-url-safe-encoded raw public key bytes of the issuer.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CertIssuerPublicKey")]
    public string? CertIssuerPublicKey { get; set; } = default!;


}