namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.4.0.0 (NJsonSchema v11.3.2.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerInspectResponse
{
    /// <summary>
    /// The ID of this container as a 128-bit (64-character) hexadecimal string (32 bytes).
    /// </summary>

    [JsonPropertyName("Id")]
    public string? Id { get; set; } = default!;

    /// <summary>
    /// Date and time at which the container was created, formatted in
    /// <br/>[RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) format with nano-seconds.
    /// </summary>

    [JsonPropertyName("Created")]
    public string? Created { get; set; } = default!;

    /// <summary>
    /// The path to the command being run
    /// </summary>

    [JsonPropertyName("Path")]
    public string? Path { get; set; } = default!;

    /// <summary>
    /// The arguments to the command being run
    /// </summary>

    [JsonPropertyName("Args")]
    public ICollection<string>? Args { get; set; } = default!;


    [JsonPropertyName("State")]
    public ContainerState? State { get; set; } = default!;

    /// <summary>
    /// The ID (digest) of the image that this container was created from.
    /// </summary>

    [JsonPropertyName("Image")]
    public string? Image { get; set; } = default!;

    /// <summary>
    /// Location of the `/etc/resolv.conf` generated for the container on the
    /// <br/>host.
    /// <br/>
    /// <br/>This file is managed through the docker daemon, and should not be
    /// <br/>accessed or modified by other tools.
    /// </summary>

    [JsonPropertyName("ResolvConfPath")]
    public string? ResolvConfPath { get; set; } = default!;

    /// <summary>
    /// Location of the `/etc/hostname` generated for the container on the
    /// <br/>host.
    /// <br/>
    /// <br/>This file is managed through the docker daemon, and should not be
    /// <br/>accessed or modified by other tools.
    /// </summary>

    [JsonPropertyName("HostnamePath")]
    public string? HostnamePath { get; set; } = default!;

    /// <summary>
    /// Location of the `/etc/hosts` generated for the container on the
    /// <br/>host.
    /// <br/>
    /// <br/>This file is managed through the docker daemon, and should not be
    /// <br/>accessed or modified by other tools.
    /// </summary>

    [JsonPropertyName("HostsPath")]
    public string? HostsPath { get; set; } = default!;

    /// <summary>
    /// Location of the file used to buffer the container's logs. Depending on
    /// <br/>the logging-driver used for the container, this field may be omitted.
    /// <br/>
    /// <br/>This file is managed through the docker daemon, and should not be
    /// <br/>accessed or modified by other tools.
    /// </summary>

    [JsonPropertyName("LogPath")]
    public string? LogPath { get; set; } = default!;

    /// <summary>
    /// The name associated with this container.
    /// <br/>
    /// <br/>For historic reasons, the name may be prefixed with a forward-slash (`/`).
    /// </summary>

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;

    /// <summary>
    /// Number of times the container was restarted since it was created,
    /// <br/>or since daemon was started.
    /// </summary>

    [JsonPropertyName("RestartCount")]
    public int? RestartCount { get; set; } = default!;

    /// <summary>
    /// The storage-driver used for the container's filesystem (graph-driver
    /// <br/>or snapshotter).
    /// </summary>

    [JsonPropertyName("Driver")]
    public string? Driver { get; set; } = default!;

    /// <summary>
    /// The platform (operating system) for which the container was created.
    /// <br/>
    /// <br/>This field was introduced for the experimental "LCOW" (Linux Containers
    /// <br/>On Windows) features, which has been removed. In most cases, this field
    /// <br/>is equal to the host's operating system (`linux` or `windows`).
    /// </summary>

    [JsonPropertyName("Platform")]
    public string? Platform { get; set; } = default!;

    /// <summary>
    /// OCI descriptor of the platform-specific manifest of the image
    /// <br/>the container was created from.
    /// <br/>
    /// <br/>Note: Only available if the daemon provides a multi-platform
    /// <br/>image store.
    /// </summary>

    [JsonPropertyName("ImageManifestDescriptor")]
    public OCIDescriptor? ImageManifestDescriptor { get; set; } = default!;

    /// <summary>
    /// SELinux mount label set for the container.
    /// </summary>

    [JsonPropertyName("MountLabel")]
    public string? MountLabel { get; set; } = default!;

    /// <summary>
    /// SELinux process label set for the container.
    /// </summary>

    [JsonPropertyName("ProcessLabel")]
    public string? ProcessLabel { get; set; } = default!;

    /// <summary>
    /// The AppArmor profile set for the container.
    /// </summary>

    [JsonPropertyName("AppArmorProfile")]
    public string? AppArmorProfile { get; set; } = default!;

    /// <summary>
    /// IDs of exec instances that are running in the container.
    /// </summary>

    [JsonPropertyName("ExecIDs")]
    public ICollection<string>? ExecIDs { get; set; } = default!;


    [JsonPropertyName("HostConfig")]
    public HostConfig? HostConfig { get; set; } = default!;


    [JsonPropertyName("GraphDriver")]
    public DriverData? GraphDriver { get; set; } = default!;

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
    /// List of mounts used by the container.
    /// </summary>

    [JsonPropertyName("Mounts")]
    public ICollection<MountPoint>? Mounts { get; set; } = default!;


    [JsonPropertyName("Config")]
    public ContainerConfig? Config { get; set; } = default!;


    [JsonPropertyName("NetworkSettings")]
    public NetworkSettings? NetworkSettings { get; set; } = default!;


}