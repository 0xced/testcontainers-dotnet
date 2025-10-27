namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerSummary
{
    /// <summary>
    /// The ID of this container as a 128-bit (64-character) hexadecimal string (32 bytes).
    /// </summary>

    [JsonPropertyName("Id")]
    public string? Id { get; set; } = default!;

    /// <summary>
    /// The names associated with this container. Most containers have a single
    /// <br/>name, but when using legacy "links", the container can have multiple
    /// <br/>names.
    /// <br/>
    /// <br/>For historic reasons, names are prefixed with a forward-slash (`/`).
    /// </summary>

    [JsonPropertyName("Names")]
    public ICollection<string>? Names { get; set; } = default!;

    /// <summary>
    /// The name or ID of the image used to create the container.
    /// <br/>
    /// <br/>This field shows the image reference as was specified when creating the container,
    /// <br/>which can be in its canonical form (e.g., `docker.io/library/ubuntu:latest`
    /// <br/>or `docker.io/library/ubuntu@sha256:72297848456d5d37d1262630108ab308d3e9ec7ed1c3286a32fe09856619a782`),
    /// <br/>short form (e.g., `ubuntu:latest`)), or the ID(-prefix) of the image (e.g., `72297848456d`).
    /// <br/>
    /// <br/>The content of this field can be updated at runtime if the image used to
    /// <br/>create the container is untagged, in which case the field is updated to
    /// <br/>contain the the image ID (digest) it was resolved to in its canonical,
    /// <br/>non-truncated form (e.g., `sha256:72297848456d5d37d1262630108ab308d3e9ec7ed1c3286a32fe09856619a782`).
    /// </summary>

    [JsonPropertyName("Image")]
    public string? Image { get; set; } = default!;

    /// <summary>
    /// The ID (digest) of the image that this container was created from.
    /// </summary>

    [JsonPropertyName("ImageID")]
    public string? ImageID { get; set; } = default!;

    /// <summary>
    /// OCI descriptor of the platform-specific manifest of the image
    /// <br/>the container was created from.
    /// <br/>
    /// <br/>Note: Only available if the daemon provides a multi-platform
    /// <br/>image store.
    /// <br/>
    /// <br/>This field is not populated in the `GET /system/df` endpoint.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ImageManifestDescriptor")]
    public OCIDescriptor? ImageManifestDescriptor { get; set; } = default!;

    /// <summary>
    /// Command to run when starting the container
    /// </summary>

    [JsonPropertyName("Command")]
    public string? Command { get; set; } = default!;

    /// <summary>
    /// Date and time at which the container was created as a Unix timestamp
    /// <br/>(number of seconds since EPOCH).
    /// </summary>

    [JsonPropertyName("Created")]
    public long? Created { get; set; } = default!;

    /// <summary>
    /// Port-mappings for the container.
    /// </summary>

    [JsonPropertyName("Ports")]
    public ICollection<Port>? Ports { get; set; } = default!;

    /// <summary>
    /// The size of files that have been created or changed by this container.
    /// <br/>
    /// <br/>This field is omitted by default, and only set when size is requested
    /// <br/>in the API request.
    /// </summary>

    [JsonPropertyName("SizeRw")]
    public long? SizeRw { get; set; } = default!;

    /// <summary>
    /// The total size of all files in the read-only layers from the image
    /// <br/>that the container uses. These layers can be shared between containers.
    /// <br/>
    /// <br/>This field is omitted by default, and only set when size is requested
    /// <br/>in the API request.
    /// </summary>

    [JsonPropertyName("SizeRootFs")]
    public long? SizeRootFs { get; set; } = default!;

    /// <summary>
    /// User-defined key/value metadata.
    /// </summary>

    [JsonPropertyName("Labels")]
    public IDictionary<string, string>? Labels { get; set; } = default!;

    /// <summary>
    /// The state of this container.
    /// <br/>
    /// </summary>

    [JsonPropertyName("State")]
    [JsonConverter(typeof(JsonEnumMemberConverter<ContainerSummaryState>))]
    public ContainerSummaryState? State { get; set; } = default!;

    /// <summary>
    /// Additional human-readable status of this container (e.g. `Exit 0`)
    /// </summary>

    [JsonPropertyName("Status")]
    public string? Status { get; set; } = default!;

    /// <summary>
    /// Summary of host-specific runtime information of the container. This
    /// <br/>is a reduced set of information in the container's "HostConfig" as
    /// <br/>available in the container "inspect" response.
    /// </summary>

    [JsonPropertyName("HostConfig")]
    public HostConfig2? HostConfig { get; set; } = default!;

    /// <summary>
    /// Summary of the container's network settings
    /// </summary>

    [JsonPropertyName("NetworkSettings")]
    public NetworkSettings2? NetworkSettings { get; set; } = default!;

    /// <summary>
    /// List of mounts used by the container.
    /// </summary>

    [JsonPropertyName("Mounts")]
    public ICollection<MountPoint>? Mounts { get; set; } = default!;


}