using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Privileges
{
    /// <summary>
    /// CredentialSpec for managed service account (Windows only)
    /// </summary>

    [JsonPropertyName("CredentialSpec")]
    public CredentialSpec? CredentialSpec { get; set; } = default!;

    /// <summary>
    /// SELinux labels of the container
    /// </summary>

    [JsonPropertyName("SELinuxContext")]
    public SELinuxContext? SELinuxContext { get; set; } = default!;

    /// <summary>
    /// Options for configuring seccomp on the container
    /// </summary>

    [JsonPropertyName("Seccomp")]
    public Seccomp? Seccomp { get; set; } = default!;

    /// <summary>
    /// Options for configuring AppArmor on the container
    /// </summary>

    [JsonPropertyName("AppArmor")]
    public AppArmor? AppArmor { get; set; } = default!;

    /// <summary>
    /// Configuration of the no_new_privs bit in the container
    /// </summary>

    [JsonPropertyName("NoNewPrivileges")]
    public bool? NoNewPrivileges { get; set; } = default!;


}