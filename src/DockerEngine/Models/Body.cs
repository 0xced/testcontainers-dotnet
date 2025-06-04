namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class Body : ContainerConfig
{

    [JsonPropertyName("HostConfig")]
    public HostConfig? HostConfig { get; set; } = default!;


    [JsonPropertyName("NetworkingConfig")]
    public NetworkingConfig? NetworkingConfig { get; set; } = default!;


}