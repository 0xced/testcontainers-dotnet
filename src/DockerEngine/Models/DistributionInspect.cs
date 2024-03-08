using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Describes the result obtained from contacting the registry to retrieve
/// <br/>image metadata.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DistributionInspect
{

    [JsonPropertyName("Descriptor")]
    public OCIDescriptor Descriptor { get; set; } = new OCIDescriptor();

    /// <summary>
    /// An array containing all platforms supported by the image.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Platforms")]
    public System.Collections.Generic.ICollection<OCIPlatform> Platforms { get; set; } = new System.Collections.ObjectModel.Collection<OCIPlatform>();


}