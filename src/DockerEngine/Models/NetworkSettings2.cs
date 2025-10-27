namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class NetworkSettings2
{
    /// <summary>
    /// Summary of network-settings for each network the container is
    /// <br/>attached to.
    /// </summary>

    [JsonPropertyName("Networks")]
    public IDictionary<string, EndpointSettings>? Networks { get; set; } = default!;


}