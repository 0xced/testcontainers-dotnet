using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Driver represents a driver (network, logging, secrets).
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Driver
{
    /// <summary>
    /// Name of the driver.
    /// </summary>

    [JsonPropertyName("Name")]
    public string Name { get; set; } = default!;

    /// <summary>
    /// Key/value map of driver-specific options.
    /// </summary>

    [JsonPropertyName("Options")]
    public IDictionary<string, string>? Options { get; set; } = default!;


}