using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Platform represents the platform (Arch/OS).
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Platform
{
    /// <summary>
    /// Architecture represents the hardware architecture (for example,
    /// <br/>`x86_64`).
    /// <br/>
    /// </summary>

    [JsonPropertyName("Architecture")]
    public string? Architecture { get; set; } = default!;

    /// <summary>
    /// OS represents the Operating System (for example, `linux` or `windows`).
    /// <br/>
    /// </summary>

    [JsonPropertyName("OS")]
    public string? OS { get; set; } = default!;


}