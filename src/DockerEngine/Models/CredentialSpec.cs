using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CredentialSpec
{
    /// <summary>
    /// Load credential spec from a Swarm Config with the given ID.
    /// <br/>The specified config must also be present in the Configs
    /// <br/>field with the Runtime property set.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>
    /// <br/>&gt; **Note**: `CredentialSpec.File`, `CredentialSpec.Registry`,
    /// <br/>&gt; and `CredentialSpec.Config` are mutually exclusive.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Config")]
    public string? Config { get; set; } = default!;

    /// <summary>
    /// Load credential spec from this file. The file is read by
    /// <br/>the daemon, and must be present in the `CredentialSpecs`
    /// <br/>subdirectory in the docker data directory, which defaults
    /// <br/>to `C:\ProgramData\Docker\` on Windows.
    /// <br/>
    /// <br/>For example, specifying `spec.json` loads
    /// <br/>`C:\ProgramData\Docker\CredentialSpecs\spec.json`.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: `CredentialSpec.File`, `CredentialSpec.Registry`,
    /// <br/>&gt; and `CredentialSpec.Config` are mutually exclusive.
    /// <br/>
    /// </summary>

    [JsonPropertyName("File")]
    public string? File { get; set; } = default!;

    /// <summary>
    /// Load credential spec from this value in the Windows
    /// <br/>registry. The specified registry value must be located in:
    /// <br/>
    /// <br/>`HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Virtualization\Containers\CredentialSpecs`
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>
    /// <br/>&gt; **Note**: `CredentialSpec.File`, `CredentialSpec.Registry`,
    /// <br/>&gt; and `CredentialSpec.Config` are mutually exclusive.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Registry")]
    public string? Registry { get; set; } = default!;


}