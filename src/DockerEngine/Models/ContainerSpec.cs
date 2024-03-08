using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContainerSpec
{
    /// <summary>
    /// The image name to use for the container
    /// </summary>

    [JsonPropertyName("Image")]
    public string? Image { get; set; } = default!;

    /// <summary>
    /// User-defined key/value data.
    /// </summary>

    [JsonPropertyName("Labels")]
    public IDictionary<string, string>? Labels { get; set; } = default!;

    /// <summary>
    /// The command to be run in the image.
    /// </summary>

    [JsonPropertyName("Command")]
    public ICollection<string>? Command { get; set; } = default!;

    /// <summary>
    /// Arguments to the command.
    /// </summary>

    [JsonPropertyName("Args")]
    public ICollection<string>? Args { get; set; } = default!;

    /// <summary>
    /// The hostname to use for the container, as a valid
    /// <br/>[RFC 1123](https://tools.ietf.org/html/rfc1123) hostname.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Hostname")]
    public string? Hostname { get; set; } = default!;

    /// <summary>
    /// A list of environment variables in the form `VAR=value`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Env")]
    public ICollection<string>? Env { get; set; } = default!;

    /// <summary>
    /// The working directory for commands to run in.
    /// </summary>

    [JsonPropertyName("Dir")]
    public string? Dir { get; set; } = default!;

    /// <summary>
    /// The user inside the container.
    /// </summary>

    [JsonPropertyName("User")]
    public string? User { get; set; } = default!;

    /// <summary>
    /// A list of additional groups that the container process will run as.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Groups")]
    public ICollection<string>? Groups { get; set; } = default!;

    /// <summary>
    /// Security options for the container
    /// </summary>

    [JsonPropertyName("Privileges")]
    public Privileges? Privileges { get; set; } = default!;

    /// <summary>
    /// Whether a pseudo-TTY should be allocated.
    /// </summary>

    [JsonPropertyName("TTY")]
    public bool? TTY { get; set; } = default!;

    /// <summary>
    /// Open `stdin`
    /// </summary>

    [JsonPropertyName("OpenStdin")]
    public bool? OpenStdin { get; set; } = default!;

    /// <summary>
    /// Mount the container's root filesystem as read only.
    /// </summary>

    [JsonPropertyName("ReadOnly")]
    public bool? ReadOnly { get; set; } = default!;

    /// <summary>
    /// Specification for mounts to be added to containers created as part
    /// <br/>of the service.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Mounts")]
    public ICollection<Mount>? Mounts { get; set; } = default!;

    /// <summary>
    /// Signal to stop the container.
    /// </summary>

    [JsonPropertyName("StopSignal")]
    public string? StopSignal { get; set; } = default!;

    /// <summary>
    /// Amount of time to wait for the container to terminate before
    /// <br/>forcefully killing it.
    /// <br/>
    /// </summary>

    [JsonPropertyName("StopGracePeriod")]
    public long? StopGracePeriod { get; set; } = default!;


    [JsonPropertyName("HealthCheck")]
    public HealthConfig? HealthCheck { get; set; } = default!;

    /// <summary>
    /// A list of hostname/IP mappings to add to the container's `hosts`
    /// <br/>file. The format of extra hosts is specified in the
    /// <br/>[hosts(5)](http://man7.org/linux/man-pages/man5/hosts.5.html)
    /// <br/>man page:
    /// <br/>
    /// <br/>    IP_address canonical_hostname [aliases...]
    /// <br/>
    /// </summary>

    [JsonPropertyName("Hosts")]
    public ICollection<string>? Hosts { get; set; } = default!;

    /// <summary>
    /// Specification for DNS related configurations in resolver configuration
    /// <br/>file (`resolv.conf`).
    /// <br/>
    /// </summary>

    [JsonPropertyName("DNSConfig")]
    public DNSConfig? DNSConfig { get; set; } = default!;

    /// <summary>
    /// Secrets contains references to zero or more secrets that will be
    /// <br/>exposed to the service.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Secrets")]
    public ICollection<Secrets>? Secrets { get; set; } = default!;

    /// <summary>
    /// Configs contains references to zero or more configs that will be
    /// <br/>exposed to the service.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Configs")]
    public ICollection<Configs>? Configs { get; set; } = default!;

    /// <summary>
    /// Isolation technology of the containers running the service.
    /// <br/>(Windows only)
    /// <br/>
    /// </summary>

    [JsonPropertyName("Isolation")]
    [JsonConverter(typeof(JsonEnumMemberConverter<ContainerSpecIsolation>))]
    public ContainerSpecIsolation? Isolation { get; set; } = default!;

    /// <summary>
    /// Run an init inside the container that forwards signals and reaps
    /// <br/>processes. This field is omitted if empty, and the default (as
    /// <br/>configured on the daemon) is used.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Init")]
    public bool? Init { get; set; } = default!;

    /// <summary>
    /// Set kernel namedspaced parameters (sysctls) in the container.
    /// <br/>The Sysctls option on services accepts the same sysctls as the
    /// <br/>are supported on containers. Note that while the same sysctls are
    /// <br/>supported, no guarantees or checks are made about their
    /// <br/>suitability for a clustered environment, and it's up to the user
    /// <br/>to determine whether a given sysctl will work properly in a
    /// <br/>Service.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Sysctls")]
    public IDictionary<string, string>? Sysctls { get; set; } = default!;

    /// <summary>
    /// A list of kernel capabilities to add to the default set
    /// <br/>for the container.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CapabilityAdd")]
    public ICollection<string>? CapabilityAdd { get; set; } = default!;

    /// <summary>
    /// A list of kernel capabilities to drop from the default set
    /// <br/>for the container.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CapabilityDrop")]
    public ICollection<string>? CapabilityDrop { get; set; } = default!;

    /// <summary>
    /// A list of resource limits to set in the container. For example: `{"Name": "nofile", "Soft": 1024, "Hard": 2048}`"
    /// <br/>
    /// </summary>

    [JsonPropertyName("Ulimits")]
    public ICollection<Ulimits2>? Ulimits { get; set; } = default!;


}