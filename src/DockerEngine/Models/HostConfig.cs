using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Container configuration that depends on the host we are running on
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class HostConfig : Resources
{
    /// <summary>
    /// A list of volume bindings for this container. Each volume binding
    /// <br/>is a string in one of these forms:
    /// <br/>
    /// <br/>- `host-src:container-dest[:options]` to bind-mount a host path
    /// <br/>  into the container. Both `host-src`, and `container-dest` must
    /// <br/>  be an _absolute_ path.
    /// <br/>- `volume-name:container-dest[:options]` to bind-mount a volume
    /// <br/>  managed by a volume driver into the container. `container-dest`
    /// <br/>  must be an _absolute_ path.
    /// <br/>
    /// <br/>`options` is an optional, comma-delimited list of:
    /// <br/>
    /// <br/>- `nocopy` disables automatic copying of data from the container
    /// <br/>  path to the volume. The `nocopy` flag only applies to named volumes.
    /// <br/>- `[ro|rw]` mounts a volume read-only or read-write, respectively.
    /// <br/>  If omitted or set to `rw`, volumes are mounted read-write.
    /// <br/>- `[z|Z]` applies SELinux labels to allow or deny multiple containers
    /// <br/>  to read and write to the same volume.
    /// <br/>    - `z`: a _shared_ content label is applied to the content. This
    /// <br/>      label indicates that multiple containers can share the volume
    /// <br/>      content, for both reading and writing.
    /// <br/>    - `Z`: a _private unshared_ label is applied to the content.
    /// <br/>      This label indicates that only the current container can use
    /// <br/>      a private volume. Labeling systems such as SELinux require
    /// <br/>      proper labels to be placed on volume content that is mounted
    /// <br/>      into a container. Without a label, the security system can
    /// <br/>      prevent a container's processes from using the content. By
    /// <br/>      default, the labels set by the host operating system are not
    /// <br/>      modified.
    /// <br/>- `[[r]shared|[r]slave|[r]private]` specifies mount
    /// <br/>  [propagation behavior](https://www.kernel.org/doc/Documentation/filesystems/sharedsubtree.txt).
    /// <br/>  This only applies to bind-mounted volumes, not internal volumes
    /// <br/>  or named volumes. Mount propagation requires the source mount
    /// <br/>  point (the location where the source directory is mounted in the
    /// <br/>  host operating system) to have the correct propagation properties.
    /// <br/>  For shared volumes, the source mount point must be set to `shared`.
    /// <br/>  For slave volumes, the mount must be set to either `shared` or
    /// <br/>  `slave`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Binds")]
    public System.Collections.Generic.ICollection<string>? Binds { get; set; } = default!;

    /// <summary>
    /// Path to a file where the container ID is written
    /// </summary>

    [JsonPropertyName("ContainerIDFile")]
    public string? ContainerIDFile { get; set; } = default!;

    /// <summary>
    /// The logging configuration for this container
    /// </summary>

    [JsonPropertyName("LogConfig")]
    public LogConfig? LogConfig { get; set; } = default!;

    /// <summary>
    /// Network mode to use for this container. Supported standard values
    /// <br/>are: `bridge`, `host`, `none`, and `container:&lt;name|id&gt;`. Any
    /// <br/>other value is taken as a custom network's name to which this
    /// <br/>container should connect to.
    /// <br/>
    /// </summary>

    [JsonPropertyName("NetworkMode")]
    public string? NetworkMode { get; set; } = default!;


    [JsonPropertyName("PortBindings")]
    public PortMap? PortBindings { get; set; } = default!;


    [JsonPropertyName("RestartPolicy")]
    public RestartPolicy? RestartPolicy { get; set; } = default!;

    /// <summary>
    /// Automatically remove the container when the container's process
    /// <br/>exits. This has no effect if `RestartPolicy` is set.
    /// <br/>
    /// </summary>

    [JsonPropertyName("AutoRemove")]
    public bool? AutoRemove { get; set; } = default!;

    /// <summary>
    /// Driver that this container uses to mount volumes.
    /// </summary>

    [JsonPropertyName("VolumeDriver")]
    public string? VolumeDriver { get; set; } = default!;

    /// <summary>
    /// A list of volumes to inherit from another container, specified in
    /// <br/>the form `&lt;container name&gt;[:&lt;ro|rw&gt;]`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("VolumesFrom")]
    public System.Collections.Generic.ICollection<string>? VolumesFrom { get; set; } = default!;

    /// <summary>
    /// Specification for mounts to be added to the container.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Mounts")]
    public System.Collections.Generic.ICollection<Mount>? Mounts { get; set; } = default!;

    /// <summary>
    /// Initial console size, as an `[height, width]` array.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ConsoleSize")]
    public System.Collections.Generic.ICollection<int>? ConsoleSize { get; set; } = default!;

    /// <summary>
    /// Arbitrary non-identifying metadata attached to container and
    /// <br/>provided to the runtime when the container is started.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Annotations")]
    public System.Collections.Generic.IDictionary<string, string>? Annotations { get; set; } = default!;

    /// <summary>
    /// A list of kernel capabilities to add to the container. Conflicts
    /// <br/>with option 'Capabilities'.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CapAdd")]
    public System.Collections.Generic.ICollection<string>? CapAdd { get; set; } = default!;

    /// <summary>
    /// A list of kernel capabilities to drop from the container. Conflicts
    /// <br/>with option 'Capabilities'.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CapDrop")]
    public System.Collections.Generic.ICollection<string>? CapDrop { get; set; } = default!;

    /// <summary>
    /// cgroup namespace mode for the container. Possible values are:
    /// <br/>
    /// <br/>- `"private"`: the container runs in its own private cgroup namespace
    /// <br/>- `"host"`: use the host system's cgroup namespace
    /// <br/>
    /// <br/>If not specified, the daemon default is used, which can either be `"private"`
    /// <br/>or `"host"`, depending on daemon version, kernel support and configuration.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CgroupnsMode")]
    [JsonConverter(typeof(JsonEnumMemberConverter<HostConfigCgroupnsMode>))]
    public HostConfigCgroupnsMode? CgroupnsMode { get; set; } = default!;

    /// <summary>
    /// A list of DNS servers for the container to use.
    /// </summary>

    [JsonPropertyName("Dns")]
    public System.Collections.Generic.ICollection<string>? Dns { get; set; } = default!;

    /// <summary>
    /// A list of DNS options.
    /// </summary>

    [JsonPropertyName("DnsOptions")]
    public System.Collections.Generic.ICollection<string>? DnsOptions { get; set; } = default!;

    /// <summary>
    /// A list of DNS search domains.
    /// </summary>

    [JsonPropertyName("DnsSearch")]
    public System.Collections.Generic.ICollection<string>? DnsSearch { get; set; } = default!;

    /// <summary>
    /// A list of hostnames/IP mappings to add to the container's `/etc/hosts`
    /// <br/>file. Specified in the form `["hostname:IP"]`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ExtraHosts")]
    public System.Collections.Generic.ICollection<string>? ExtraHosts { get; set; } = default!;

    /// <summary>
    /// A list of additional groups that the container process will run as.
    /// <br/>
    /// </summary>

    [JsonPropertyName("GroupAdd")]
    public System.Collections.Generic.ICollection<string>? GroupAdd { get; set; } = default!;

    /// <summary>
    /// IPC sharing mode for the container. Possible values are:
    /// <br/>
    /// <br/>- `"none"`: own private IPC namespace, with /dev/shm not mounted
    /// <br/>- `"private"`: own private IPC namespace
    /// <br/>- `"shareable"`: own private IPC namespace, with a possibility to share it with other containers
    /// <br/>- `"container:&lt;name|id&gt;"`: join another (shareable) container's IPC namespace
    /// <br/>- `"host"`: use the host system's IPC namespace
    /// <br/>
    /// <br/>If not specified, daemon default is used, which can either be `"private"`
    /// <br/>or `"shareable"`, depending on daemon version and configuration.
    /// <br/>
    /// </summary>

    [JsonPropertyName("IpcMode")]
    public string? IpcMode { get; set; } = default!;

    /// <summary>
    /// Cgroup to use for the container.
    /// </summary>

    [JsonPropertyName("Cgroup")]
    public string? Cgroup { get; set; } = default!;

    /// <summary>
    /// A list of links for the container in the form `container_name:alias`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Links")]
    public System.Collections.Generic.ICollection<string>? Links { get; set; } = default!;

    /// <summary>
    /// An integer value containing the score given to the container in
    /// <br/>order to tune OOM killer preferences.
    /// <br/>
    /// </summary>

    [JsonPropertyName("OomScoreAdj")]
    public int? OomScoreAdj { get; set; } = default!;

    /// <summary>
    /// Set the PID (Process) Namespace mode for the container. It can be
    /// <br/>either:
    /// <br/>
    /// <br/>- `"container:&lt;name|id&gt;"`: joins another container's PID namespace
    /// <br/>- `"host"`: use the host's PID namespace inside the container
    /// <br/>
    /// </summary>

    [JsonPropertyName("PidMode")]
    public string? PidMode { get; set; } = default!;

    /// <summary>
    /// Gives the container full access to the host.
    /// </summary>

    [JsonPropertyName("Privileged")]
    public bool? Privileged { get; set; } = default!;

    /// <summary>
    /// Allocates an ephemeral host port for all of a container's
    /// <br/>exposed ports.
    /// <br/>
    /// <br/>Ports are de-allocated when the container stops and allocated when
    /// <br/>the container starts. The allocated port might be changed when
    /// <br/>restarting the container.
    /// <br/>
    /// <br/>The port is selected from the ephemeral port range that depends on
    /// <br/>the kernel. For example, on Linux the range is defined by
    /// <br/>`/proc/sys/net/ipv4/ip_local_port_range`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("PublishAllPorts")]
    public bool? PublishAllPorts { get; set; } = default!;

    /// <summary>
    /// Mount the container's root filesystem as read only.
    /// </summary>

    [JsonPropertyName("ReadonlyRootfs")]
    public bool? ReadonlyRootfs { get; set; } = default!;

    /// <summary>
    /// A list of string values to customize labels for MLS systems, such
    /// <br/>as SELinux.
    /// <br/>
    /// </summary>

    [JsonPropertyName("SecurityOpt")]
    public System.Collections.Generic.ICollection<string>? SecurityOpt { get; set; } = default!;

    /// <summary>
    /// Storage driver options for this container, in the form `{"size": "120G"}`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("StorageOpt")]
    public System.Collections.Generic.IDictionary<string, string>? StorageOpt { get; set; } = default!;

    /// <summary>
    /// A map of container directories which should be replaced by tmpfs
    /// <br/>mounts, and their corresponding mount options. For example:
    /// <br/>
    /// <br/>```
    /// <br/>{ "/run": "rw,noexec,nosuid,size=65536k" }
    /// <br/>```
    /// <br/>
    /// </summary>

    [JsonPropertyName("Tmpfs")]
    public System.Collections.Generic.IDictionary<string, string>? Tmpfs { get; set; } = default!;

    /// <summary>
    /// UTS namespace to use for the container.
    /// </summary>

    [JsonPropertyName("UTSMode")]
    public string? UTSMode { get; set; } = default!;

    /// <summary>
    /// Sets the usernamespace mode for the container when usernamespace
    /// <br/>remapping option is enabled.
    /// <br/>
    /// </summary>

    [JsonPropertyName("UsernsMode")]
    public string? UsernsMode { get; set; } = default!;

    /// <summary>
    /// Size of `/dev/shm` in bytes. If omitted, the system uses 64MB.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ShmSize")]
    public long? ShmSize { get; set; } = default!;

    /// <summary>
    /// A list of kernel parameters (sysctls) to set in the container.
    /// <br/>For example:
    /// <br/>
    /// <br/>```
    /// <br/>{"net.ipv4.ip_forward": "1"}
    /// <br/>```
    /// <br/>
    /// </summary>

    [JsonPropertyName("Sysctls")]
    public System.Collections.Generic.IDictionary<string, string>? Sysctls { get; set; } = default!;

    /// <summary>
    /// Runtime to use with this container.
    /// </summary>

    [JsonPropertyName("Runtime")]
    public string? Runtime { get; set; } = default!;

    /// <summary>
    /// Isolation technology of the container. (Windows only)
    /// <br/>
    /// </summary>

    [JsonPropertyName("Isolation")]
    [JsonConverter(typeof(JsonEnumMemberConverter<HostConfigIsolation>))]
    public HostConfigIsolation? Isolation { get; set; } = default!;

    /// <summary>
    /// The list of paths to be masked inside the container (this overrides
    /// <br/>the default set of paths).
    /// <br/>
    /// </summary>

    [JsonPropertyName("MaskedPaths")]
    public System.Collections.Generic.ICollection<string>? MaskedPaths { get; set; } = default!;

    /// <summary>
    /// The list of paths to be set as read-only inside the container
    /// <br/>(this overrides the default set of paths).
    /// <br/>
    /// </summary>

    [JsonPropertyName("ReadonlyPaths")]
    public System.Collections.Generic.ICollection<string>? ReadonlyPaths { get; set; } = default!;


}