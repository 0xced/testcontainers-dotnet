using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SystemInfo
{
    /// <summary>
    /// Unique identifier of the daemon.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: The format of the ID itself is not part of the API, and
    /// <br/>&gt; should not be considered stable.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ID")]
    public string? ID { get; set; } = default!;

    /// <summary>
    /// Total number of containers on the host.
    /// </summary>

    [JsonPropertyName("Containers")]
    public int? Containers { get; set; } = default!;

    /// <summary>
    /// Number of containers with status `"running"`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ContainersRunning")]
    public int? ContainersRunning { get; set; } = default!;

    /// <summary>
    /// Number of containers with status `"paused"`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ContainersPaused")]
    public int? ContainersPaused { get; set; } = default!;

    /// <summary>
    /// Number of containers with status `"stopped"`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ContainersStopped")]
    public int? ContainersStopped { get; set; } = default!;

    /// <summary>
    /// Total number of images on the host.
    /// <br/>
    /// <br/>Both _tagged_ and _untagged_ (dangling) images are counted.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Images")]
    public int? Images { get; set; } = default!;

    /// <summary>
    /// Name of the storage driver in use.
    /// </summary>

    [JsonPropertyName("Driver")]
    public string? Driver { get; set; } = default!;

    /// <summary>
    /// Information specific to the storage driver, provided as
    /// <br/>"label" / "value" pairs.
    /// <br/>
    /// <br/>This information is provided by the storage driver, and formatted
    /// <br/>in a way consistent with the output of `docker info` on the command
    /// <br/>line.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: The information returned in this field, including the
    /// <br/>&gt; formatting of values and labels, should not be considered stable,
    /// <br/>&gt; and may change without notice.
    /// <br/>
    /// </summary>

    [JsonPropertyName("DriverStatus")]
    public System.Collections.Generic.ICollection<System.Collections.Generic.ICollection<string>>? DriverStatus { get; set; } = default!;

    /// <summary>
    /// Root directory of persistent Docker state.
    /// <br/>
    /// <br/>Defaults to `/var/lib/docker` on Linux, and `C:\ProgramData\docker`
    /// <br/>on Windows.
    /// <br/>
    /// </summary>

    [JsonPropertyName("DockerRootDir")]
    public string? DockerRootDir { get; set; } = default!;


    [JsonPropertyName("Plugins")]
    public PluginsInfo? Plugins { get; set; } = default!;

    /// <summary>
    /// Indicates if the host has memory limit support enabled.
    /// </summary>

    [JsonPropertyName("MemoryLimit")]
    public bool? MemoryLimit { get; set; } = default!;

    /// <summary>
    /// Indicates if the host has memory swap limit support enabled.
    /// </summary>

    [JsonPropertyName("SwapLimit")]
    public bool? SwapLimit { get; set; } = default!;

    /// <summary>
    /// Indicates if the host has kernel memory TCP limit support enabled. This
    /// <br/>field is omitted if not supported.
    /// <br/>
    /// <br/>Kernel memory TCP limits are not supported when using cgroups v2, which
    /// <br/>does not support the corresponding `memory.kmem.tcp.limit_in_bytes` cgroup.
    /// <br/>
    /// </summary>

    [JsonPropertyName("KernelMemoryTCP")]
    public bool? KernelMemoryTCP { get; set; } = default!;

    /// <summary>
    /// Indicates if CPU CFS(Completely Fair Scheduler) period is supported by
    /// <br/>the host.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CpuCfsPeriod")]
    public bool? CpuCfsPeriod { get; set; } = default!;

    /// <summary>
    /// Indicates if CPU CFS(Completely Fair Scheduler) quota is supported by
    /// <br/>the host.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CpuCfsQuota")]
    public bool? CpuCfsQuota { get; set; } = default!;

    /// <summary>
    /// Indicates if CPU Shares limiting is supported by the host.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CPUShares")]
    public bool? CPUShares { get; set; } = default!;

    /// <summary>
    /// Indicates if CPUsets (cpuset.cpus, cpuset.mems) are supported by the host.
    /// <br/>
    /// <br/>See [cpuset(7)](https://www.kernel.org/doc/Documentation/cgroup-v1/cpusets.txt)
    /// <br/>
    /// </summary>

    [JsonPropertyName("CPUSet")]
    public bool? CPUSet { get; set; } = default!;

    /// <summary>
    /// Indicates if the host kernel has PID limit support enabled.
    /// </summary>

    [JsonPropertyName("PidsLimit")]
    public bool? PidsLimit { get; set; } = default!;

    /// <summary>
    /// Indicates if OOM killer disable is supported on the host.
    /// </summary>

    [JsonPropertyName("OomKillDisable")]
    public bool? OomKillDisable { get; set; } = default!;

    /// <summary>
    /// Indicates IPv4 forwarding is enabled.
    /// </summary>

    [JsonPropertyName("IPv4Forwarding")]
    public bool? IPv4Forwarding { get; set; } = default!;

    /// <summary>
    /// Indicates if `bridge-nf-call-iptables` is available on the host.
    /// </summary>

    [JsonPropertyName("BridgeNfIptables")]
    public bool? BridgeNfIptables { get; set; } = default!;

    /// <summary>
    /// Indicates if `bridge-nf-call-ip6tables` is available on the host.
    /// </summary>

    [JsonPropertyName("BridgeNfIp6tables")]
    public bool? BridgeNfIp6tables { get; set; } = default!;

    /// <summary>
    /// Indicates if the daemon is running in debug-mode / with debug-level
    /// <br/>logging enabled.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Debug")]
    public bool? Debug { get; set; } = default!;

    /// <summary>
    /// The total number of file Descriptors in use by the daemon process.
    /// <br/>
    /// <br/>This information is only returned if debug-mode is enabled.
    /// <br/>
    /// </summary>

    [JsonPropertyName("NFd")]
    public int? NFd { get; set; } = default!;

    /// <summary>
    /// The  number of goroutines that currently exist.
    /// <br/>
    /// <br/>This information is only returned if debug-mode is enabled.
    /// <br/>
    /// </summary>

    [JsonPropertyName("NGoroutines")]
    public int? NGoroutines { get; set; } = default!;

    /// <summary>
    /// Current system-time in [RFC 3339](https://www.ietf.org/rfc/rfc3339.txt)
    /// <br/>format with nano-seconds.
    /// <br/>
    /// </summary>

    [JsonPropertyName("SystemTime")]
    public string? SystemTime { get; set; } = default!;

    /// <summary>
    /// The logging driver to use as a default for new containers.
    /// <br/>
    /// </summary>

    [JsonPropertyName("LoggingDriver")]
    public string? LoggingDriver { get; set; } = default!;

    /// <summary>
    /// The driver to use for managing cgroups.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CgroupDriver")]
    [JsonConverter(typeof(JsonEnumMemberConverter<SystemInfoCgroupDriver>))]
    public SystemInfoCgroupDriver? CgroupDriver { get; set; } = DockerEngine.SystemInfoCgroupDriver.Cgroupfs;

    /// <summary>
    /// The version of the cgroup.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CgroupVersion")]
    [JsonConverter(typeof(JsonEnumMemberConverter<SystemInfoCgroupVersion>))]
    public SystemInfoCgroupVersion? CgroupVersion { get; set; } = DockerEngine.SystemInfoCgroupVersion._1;

    /// <summary>
    /// Number of event listeners subscribed.
    /// </summary>

    [JsonPropertyName("NEventsListener")]
    public int? NEventsListener { get; set; } = default!;

    /// <summary>
    /// Kernel version of the host.
    /// <br/>
    /// <br/>On Linux, this information obtained from `uname`. On Windows this
    /// <br/>information is queried from the &lt;kbd&gt;HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\&lt;/kbd&gt;
    /// <br/>registry value, for example _"10.0 14393 (14393.1198.amd64fre.rs1_release_sec.170427-1353)"_.
    /// <br/>
    /// </summary>

    [JsonPropertyName("KernelVersion")]
    public string? KernelVersion { get; set; } = default!;

    /// <summary>
    /// Name of the host's operating system, for example: "Ubuntu 16.04.2 LTS"
    /// <br/>or "Windows Server 2016 Datacenter"
    /// <br/>
    /// </summary>

    [JsonPropertyName("OperatingSystem")]
    public string? OperatingSystem { get; set; } = default!;

    /// <summary>
    /// Version of the host's operating system
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: The information returned in this field, including its
    /// <br/>&gt; very existence, and the formatting of values, should not be considered
    /// <br/>&gt; stable, and may change without notice.
    /// <br/>
    /// </summary>

    [JsonPropertyName("OSVersion")]
    public string? OSVersion { get; set; } = default!;

    /// <summary>
    /// Generic type of the operating system of the host, as returned by the
    /// <br/>Go runtime (`GOOS`).
    /// <br/>
    /// <br/>Currently returned values are "linux" and "windows". A full list of
    /// <br/>possible values can be found in the [Go documentation](https://go.dev/doc/install/source#environment).
    /// <br/>
    /// </summary>

    [JsonPropertyName("OSType")]
    public string? OSType { get; set; } = default!;

    /// <summary>
    /// Hardware architecture of the host, as returned by the Go runtime
    /// <br/>(`GOARCH`).
    /// <br/>
    /// <br/>A full list of possible values can be found in the [Go documentation](https://go.dev/doc/install/source#environment).
    /// <br/>
    /// </summary>

    [JsonPropertyName("Architecture")]
    public string? Architecture { get; set; } = default!;

    /// <summary>
    /// The number of logical CPUs usable by the daemon.
    /// <br/>
    /// <br/>The number of available CPUs is checked by querying the operating
    /// <br/>system when the daemon starts. Changes to operating system CPU
    /// <br/>allocation after the daemon is started are not reflected.
    /// <br/>
    /// </summary>

    [JsonPropertyName("NCPU")]
    public int? NCPU { get; set; } = default!;

    /// <summary>
    /// Total amount of physical memory available on the host, in bytes.
    /// <br/>
    /// </summary>

    [JsonPropertyName("MemTotal")]
    public long? MemTotal { get; set; } = default!;

    /// <summary>
    /// Address / URL of the index server that is used for image search,
    /// <br/>and as a default for user authentication for Docker Hub and Docker Cloud.
    /// <br/>
    /// </summary>

    [JsonPropertyName("IndexServerAddress")]
    public string? IndexServerAddress { get; set; } = "https://index.docker.io/v1/";


    [JsonPropertyName("RegistryConfig")]
    public RegistryServiceConfig? RegistryConfig { get; set; } = default!;


    [JsonPropertyName("GenericResources")]
    public GenericResources? GenericResources { get; set; } = default!;

    /// <summary>
    /// HTTP-proxy configured for the daemon. This value is obtained from the
    /// <br/>[`HTTP_PROXY`](https://www.gnu.org/software/wget/manual/html_node/Proxies.html) environment variable.
    /// <br/>Credentials ([user info component](https://tools.ietf.org/html/rfc3986#section-3.2.1)) in the proxy URL
    /// <br/>are masked in the API response.
    /// <br/>
    /// <br/>Containers do not automatically inherit this configuration.
    /// <br/>
    /// </summary>

    [JsonPropertyName("HttpProxy")]
    public string? HttpProxy { get; set; } = default!;

    /// <summary>
    /// HTTPS-proxy configured for the daemon. This value is obtained from the
    /// <br/>[`HTTPS_PROXY`](https://www.gnu.org/software/wget/manual/html_node/Proxies.html) environment variable.
    /// <br/>Credentials ([user info component](https://tools.ietf.org/html/rfc3986#section-3.2.1)) in the proxy URL
    /// <br/>are masked in the API response.
    /// <br/>
    /// <br/>Containers do not automatically inherit this configuration.
    /// <br/>
    /// </summary>

    [JsonPropertyName("HttpsProxy")]
    public string? HttpsProxy { get; set; } = default!;

    /// <summary>
    /// Comma-separated list of domain extensions for which no proxy should be
    /// <br/>used. This value is obtained from the [`NO_PROXY`](https://www.gnu.org/software/wget/manual/html_node/Proxies.html)
    /// <br/>environment variable.
    /// <br/>
    /// <br/>Containers do not automatically inherit this configuration.
    /// <br/>
    /// </summary>

    [JsonPropertyName("NoProxy")]
    public string? NoProxy { get; set; } = default!;

    /// <summary>
    /// Hostname of the host.
    /// </summary>

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;

    /// <summary>
    /// User-defined labels (key/value metadata) as set on the daemon.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: When part of a Swarm, nodes can both have _daemon_ labels,
    /// <br/>&gt; set through the daemon configuration, and _node_ labels, set from a
    /// <br/>&gt; manager node in the Swarm. Node labels are not included in this
    /// <br/>&gt; field. Node labels can be retrieved using the `/nodes/(id)` endpoint
    /// <br/>&gt; on a manager node in the Swarm.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Labels")]
    public System.Collections.Generic.ICollection<string>? Labels { get; set; } = default!;

    /// <summary>
    /// Indicates if experimental features are enabled on the daemon.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ExperimentalBuild")]
    public bool? ExperimentalBuild { get; set; } = default!;

    /// <summary>
    /// Version string of the daemon.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ServerVersion")]
    public string? ServerVersion { get; set; } = default!;

    /// <summary>
    /// List of [OCI compliant](https://github.com/opencontainers/runtime-spec)
    /// <br/>runtimes configured on the daemon. Keys hold the "name" used to
    /// <br/>reference the runtime.
    /// <br/>
    /// <br/>The Docker daemon relies on an OCI compliant runtime (invoked via the
    /// <br/>`containerd` daemon) as its interface to the Linux kernel namespaces,
    /// <br/>cgroups, and SELinux.
    /// <br/>
    /// <br/>The default runtime is `runc`, and automatically configured. Additional
    /// <br/>runtimes can be configured by the user and will be listed here.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Runtimes")]
    public System.Collections.Generic.IDictionary<string, Runtime>? Runtimes { get; set; } = default!;

    /// <summary>
    /// Name of the default OCI runtime that is used when starting containers.
    /// <br/>
    /// <br/>The default can be overridden per-container at create time.
    /// <br/>
    /// </summary>

    [JsonPropertyName("DefaultRuntime")]
    public string? DefaultRuntime { get; set; } = "runc";


    [JsonPropertyName("Swarm")]
    public SwarmInfo? Swarm { get; set; } = default!;

    /// <summary>
    /// Indicates if live restore is enabled.
    /// <br/>
    /// <br/>If enabled, containers are kept running when the daemon is shutdown
    /// <br/>or upon daemon start if running containers are detected.
    /// <br/>
    /// </summary>

    [JsonPropertyName("LiveRestoreEnabled")]
    public bool? LiveRestoreEnabled { get; set; } = false;

    /// <summary>
    /// Represents the isolation technology to use as a default for containers.
    /// <br/>The supported values are platform-specific.
    /// <br/>
    /// <br/>If no isolation value is specified on daemon start, on Windows client,
    /// <br/>the default is `hyperv`, and on Windows server, the default is `process`.
    /// <br/>
    /// <br/>This option is currently not used on other platforms.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Isolation")]
    [JsonConverter(typeof(JsonEnumMemberConverter<SystemInfoIsolation>))]
    public SystemInfoIsolation? Isolation { get; set; } = DockerEngine.SystemInfoIsolation.Default;

    /// <summary>
    /// Name and, optional, path of the `docker-init` binary.
    /// <br/>
    /// <br/>If the path is omitted, the daemon searches the host's `$PATH` for the
    /// <br/>binary and uses the first result.
    /// <br/>
    /// </summary>

    [JsonPropertyName("InitBinary")]
    public string? InitBinary { get; set; } = default!;


    [JsonPropertyName("ContainerdCommit")]
    public Commit? ContainerdCommit { get; set; } = default!;


    [JsonPropertyName("RuncCommit")]
    public Commit? RuncCommit { get; set; } = default!;


    [JsonPropertyName("InitCommit")]
    public Commit? InitCommit { get; set; } = default!;

    /// <summary>
    /// List of security features that are enabled on the daemon, such as
    /// <br/>apparmor, seccomp, SELinux, user-namespaces (userns), rootless and
    /// <br/>no-new-privileges.
    /// <br/>
    /// <br/>Additional configuration options for each security feature may
    /// <br/>be present, and are included as a comma-separated list of key/value
    /// <br/>pairs.
    /// <br/>
    /// </summary>

    [JsonPropertyName("SecurityOptions")]
    public System.Collections.Generic.ICollection<string>? SecurityOptions { get; set; } = default!;

    /// <summary>
    /// Reports a summary of the product license on the daemon.
    /// <br/>
    /// <br/>If a commercial license has been applied to the daemon, information
    /// <br/>such as number of nodes, and expiration are included.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ProductLicense")]
    public string? ProductLicense { get; set; } = default!;

    /// <summary>
    /// List of custom default address pools for local networks, which can be
    /// <br/>specified in the daemon.json file or dockerd option.
    /// <br/>
    /// <br/>Example: a Base "10.10.0.0/16" with Size 24 will define the set of 256
    /// <br/>10.10.[0-255].0/24 address pools.
    /// <br/>
    /// </summary>

    [JsonPropertyName("DefaultAddressPools")]
    public System.Collections.Generic.ICollection<DefaultAddressPools>? DefaultAddressPools { get; set; } = default!;

    /// <summary>
    /// List of warnings / informational messages about missing features, or
    /// <br/>issues related to the daemon configuration.
    /// <br/>
    /// <br/>These messages can be printed by the client as information to the user.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Warnings")]
    public System.Collections.Generic.ICollection<string>? Warnings { get; set; } = default!;

    /// <summary>
    /// List of directories where (Container Device Interface) CDI
    /// <br/>specifications are located.
    /// <br/>
    /// <br/>These specifications define vendor-specific modifications to an OCI
    /// <br/>runtime specification for a container being created.
    /// <br/>
    /// <br/>An empty list indicates that CDI device injection is disabled.
    /// <br/>
    /// <br/>Note that since using CDI device injection requires the daemon to have
    /// <br/>experimental enabled. For non-experimental daemons an empty list will
    /// <br/>always be returned.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CDISpecDirs")]
    public System.Collections.Generic.ICollection<string>? CDISpecDirs { get; set; } = default!;


}