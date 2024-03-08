using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Runtime describes an [OCI compliant](https://github.com/opencontainers/runtime-spec)
/// <br/>runtime.
/// <br/>
/// <br/>The runtime is invoked by the daemon via the `containerd` daemon. OCI
/// <br/>runtimes act as an interface to the Linux kernel namespaces, cgroups,
/// <br/>and SELinux.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Runtime
{
    /// <summary>
    /// Name and, optional, path, of the OCI executable binary.
    /// <br/>
    /// <br/>If the path is omitted, the daemon searches the host's `$PATH` for the
    /// <br/>binary and uses the first result.
    /// <br/>
    /// </summary>

    [JsonPropertyName("path")]
    public string? Path { get; set; } = default!;

    /// <summary>
    /// List of command-line arguments to pass to the runtime when invoked.
    /// <br/>
    /// </summary>

    [JsonPropertyName("runtimeArgs")]
    public ICollection<string>? RuntimeArgs { get; set; } = default!;

    /// <summary>
    /// Information specific to the runtime.
    /// <br/>
    /// <br/>While this API specification does not define data provided by runtimes,
    /// <br/>the following well-known properties may be provided by runtimes:
    /// <br/>
    /// <br/>`org.opencontainers.runtime-spec.features`: features structure as defined
    /// <br/>in the [OCI Runtime Specification](https://github.com/opencontainers/runtime-spec/blob/main/features.md),
    /// <br/>in a JSON string representation.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: The information returned in this field, including the
    /// <br/>&gt; formatting of values and labels, should not be considered stable,
    /// <br/>&gt; and may change without notice.
    /// <br/>
    /// </summary>

    [JsonPropertyName("status")]
    public IDictionary<string, string>? Status { get; set; } = default!;


}