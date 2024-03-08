using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SELinuxContext
{
    /// <summary>
    /// Disable SELinux
    /// </summary>

    [JsonPropertyName("Disable")]
    public bool? Disable { get; set; } = default!;

    /// <summary>
    /// SELinux user label
    /// </summary>

    [JsonPropertyName("User")]
    public string? User { get; set; } = default!;

    /// <summary>
    /// SELinux role label
    /// </summary>

    [JsonPropertyName("Role")]
    public string? Role { get; set; } = default!;

    /// <summary>
    /// SELinux type label
    /// </summary>

    [JsonPropertyName("Type")]
    public string? Type { get; set; } = default!;

    /// <summary>
    /// SELinux level label
    /// </summary>

    [JsonPropertyName("Level")]
    public string? Level { get; set; } = default!;


}