using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AccessMode
{
    /// <summary>
    /// The set of nodes this volume can be used on at one time.
    /// <br/>- `single` The volume may only be scheduled to one node at a time.
    /// <br/>- `multi` the volume may be scheduled to any supported number of nodes at a time.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Scope")]
    [JsonConverter(typeof(JsonEnumMemberConverter<AccessModeScope>))]
    public AccessModeScope? Scope { get; set; } = DockerEngine.AccessModeScope.Single;

    /// <summary>
    /// The number and way that different tasks can use this volume
    /// <br/>at one time.
    /// <br/>- `none` The volume may only be used by one task at a time.
    /// <br/>- `readonly` The volume may be used by any number of tasks, but they all must mount the volume as readonly
    /// <br/>- `onewriter` The volume may be used by any number of tasks, but only one may mount it as read/write.
    /// <br/>- `all` The volume may have any number of readers and writers.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Sharing")]
    [JsonConverter(typeof(JsonEnumMemberConverter<AccessModeSharing>))]
    public AccessModeSharing? Sharing { get; set; } = DockerEngine.AccessModeSharing.None;

    /// <summary>
    /// Options for using this volume as a Mount-type volume.
    /// <br/>
    /// <br/>    Either MountVolume or BlockVolume, but not both, must be
    /// <br/>    present.
    /// <br/>  properties:
    /// <br/>    FsType:
    /// <br/>      type: "string"
    /// <br/>      description: |
    /// <br/>        Specifies the filesystem type for the mount volume.
    /// <br/>        Optional.
    /// <br/>    MountFlags:
    /// <br/>      type: "array"
    /// <br/>      description: |
    /// <br/>        Flags to pass when mounting the volume. Optional.
    /// <br/>      items:
    /// <br/>        type: "string"
    /// <br/>BlockVolume:
    /// <br/>  type: "object"
    /// <br/>  description: |
    /// <br/>    Options for using this volume as a Block-type volume.
    /// <br/>    Intentionally empty.
    /// <br/>
    /// </summary>

    [JsonPropertyName("MountVolume")]
    public object? MountVolume { get; set; } = default!;

    /// <summary>
    /// Swarm Secrets that are passed to the CSI storage plugin when
    /// <br/>operating on this volume.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Secrets")]
    public System.Collections.Generic.ICollection<Secrets2>? Secrets { get; set; } = default!;

    /// <summary>
    /// Requirements for the accessible topology of the volume. These
    /// <br/>fields are optional. For an in-depth description of what these
    /// <br/>fields mean, see the CSI specification.
    /// <br/>
    /// </summary>

    [JsonPropertyName("AccessibilityRequirements")]
    public AccessibilityRequirements? AccessibilityRequirements { get; set; } = default!;

    /// <summary>
    /// The desired capacity that the volume should be created with. If
    /// <br/>empty, the plugin will decide the capacity.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CapacityRange")]
    public CapacityRange? CapacityRange { get; set; } = default!;

    /// <summary>
    /// The availability of the volume for use in tasks.
    /// <br/>- `active` The volume is fully available for scheduling on the cluster
    /// <br/>- `pause` No new workloads should use the volume, but existing workloads are not stopped.
    /// <br/>- `drain` All workloads using this volume should be stopped and rescheduled, and no new ones should be started.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Availability")]
    [JsonConverter(typeof(JsonEnumMemberConverter<AccessModeAvailability>))]
    public AccessModeAvailability? Availability { get; set; } = DockerEngine.AccessModeAvailability.Active;


}