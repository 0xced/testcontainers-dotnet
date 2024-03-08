using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// MountPoint represents a mount point configuration inside the container.
/// <br/>This is used for reporting the mountpoints in use by a container.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MountPoint
{
    /// <summary>
    /// The mount type:
    /// <br/>
    /// <br/>- `bind` a mount of a file or directory from the host into the container.
    /// <br/>- `volume` a docker volume with the given `Name`.
    /// <br/>- `tmpfs` a `tmpfs`.
    /// <br/>- `npipe` a named pipe from the host into the container.
    /// <br/>- `cluster` a Swarm cluster volume
    /// <br/>
    /// </summary>

    [JsonPropertyName("Type")]
    [JsonConverter(typeof(JsonEnumMemberConverter<MountPointType>))]
    public MountPointType? Type { get; set; } = default!;

    /// <summary>
    /// Name is the name reference to the underlying data defined by `Source`
    /// <br/>e.g., the volume name.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;

    /// <summary>
    /// Source location of the mount.
    /// <br/>
    /// <br/>For volumes, this contains the storage location of the volume (within
    /// <br/>`/var/lib/docker/volumes/`). For bind-mounts, and `npipe`, this contains
    /// <br/>the source (host) part of the bind-mount. For `tmpfs` mount points, this
    /// <br/>field is empty.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Source")]
    public string? Source { get; set; } = default!;

    /// <summary>
    /// Destination is the path relative to the container root (`/`) where
    /// <br/>the `Source` is mounted inside the container.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Destination")]
    public string? Destination { get; set; } = default!;

    /// <summary>
    /// Driver is the volume driver used to create the volume (if it is a volume).
    /// <br/>
    /// </summary>

    [JsonPropertyName("Driver")]
    public string? Driver { get; set; } = default!;

    /// <summary>
    /// Mode is a comma separated list of options supplied by the user when
    /// <br/>creating the bind/volume mount.
    /// <br/>
    /// <br/>The default is platform-specific (`"z"` on Linux, empty on Windows).
    /// <br/>
    /// </summary>

    [JsonPropertyName("Mode")]
    public string? Mode { get; set; } = default!;

    /// <summary>
    /// Whether the mount is mounted writable (read-write).
    /// <br/>
    /// </summary>

    [JsonPropertyName("RW")]
    public bool? RW { get; set; } = default!;

    /// <summary>
    /// Propagation describes how mounts are propagated from the host into the
    /// <br/>mount point, and vice-versa. Refer to the [Linux kernel documentation](https://www.kernel.org/doc/Documentation/filesystems/sharedsubtree.txt)
    /// <br/>for details. This field is not used on Windows.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Propagation")]
    public string? Propagation { get; set; } = default!;


}