using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// A container's resources (cgroups config, ulimits, etc)
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Resources
{
    /// <summary>
    /// An integer value representing this container's relative CPU weight
    /// <br/>versus other containers.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CpuShares")]
    public int? CpuShares { get; set; } = default!;

    /// <summary>
    /// Memory limit in bytes.
    /// </summary>

    [JsonPropertyName("Memory")]
    public long? Memory { get; set; } = 0L;

    /// <summary>
    /// Path to `cgroups` under which the container's `cgroup` is created. If
    /// <br/>the path is not absolute, the path is considered to be relative to the
    /// <br/>`cgroups` path of the init process. Cgroups are created if they do not
    /// <br/>already exist.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CgroupParent")]
    public string? CgroupParent { get; set; } = default!;

    /// <summary>
    /// Block IO weight (relative weight).
    /// </summary>

    [JsonPropertyName("BlkioWeight")]
    public int? BlkioWeight { get; set; } = default!;

    /// <summary>
    /// Block IO weight (relative device weight) in the form:
    /// <br/>
    /// <br/>```
    /// <br/>[{"Path": "device_path", "Weight": weight}]
    /// <br/>```
    /// <br/>
    /// </summary>

    [JsonPropertyName("BlkioWeightDevice")]
    public ICollection<BlkioWeightDevice>? BlkioWeightDevice { get; set; } = default!;

    /// <summary>
    /// Limit read rate (bytes per second) from a device, in the form:
    /// <br/>
    /// <br/>```
    /// <br/>[{"Path": "device_path", "Rate": rate}]
    /// <br/>```
    /// <br/>
    /// </summary>

    [JsonPropertyName("BlkioDeviceReadBps")]
    public ICollection<ThrottleDevice>? BlkioDeviceReadBps { get; set; } = default!;

    /// <summary>
    /// Limit write rate (bytes per second) to a device, in the form:
    /// <br/>
    /// <br/>```
    /// <br/>[{"Path": "device_path", "Rate": rate}]
    /// <br/>```
    /// <br/>
    /// </summary>

    [JsonPropertyName("BlkioDeviceWriteBps")]
    public ICollection<ThrottleDevice>? BlkioDeviceWriteBps { get; set; } = default!;

    /// <summary>
    /// Limit read rate (IO per second) from a device, in the form:
    /// <br/>
    /// <br/>```
    /// <br/>[{"Path": "device_path", "Rate": rate}]
    /// <br/>```
    /// <br/>
    /// </summary>

    [JsonPropertyName("BlkioDeviceReadIOps")]
    public ICollection<ThrottleDevice>? BlkioDeviceReadIOps { get; set; } = default!;

    /// <summary>
    /// Limit write rate (IO per second) to a device, in the form:
    /// <br/>
    /// <br/>```
    /// <br/>[{"Path": "device_path", "Rate": rate}]
    /// <br/>```
    /// <br/>
    /// </summary>

    [JsonPropertyName("BlkioDeviceWriteIOps")]
    public ICollection<ThrottleDevice>? BlkioDeviceWriteIOps { get; set; } = default!;

    /// <summary>
    /// The length of a CPU period in microseconds.
    /// </summary>

    [JsonPropertyName("CpuPeriod")]
    public long? CpuPeriod { get; set; } = default!;

    /// <summary>
    /// Microseconds of CPU time that the container can get in a CPU period.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CpuQuota")]
    public long? CpuQuota { get; set; } = default!;

    /// <summary>
    /// The length of a CPU real-time period in microseconds. Set to 0 to
    /// <br/>allocate no time allocated to real-time tasks.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CpuRealtimePeriod")]
    public long? CpuRealtimePeriod { get; set; } = default!;

    /// <summary>
    /// The length of a CPU real-time runtime in microseconds. Set to 0 to
    /// <br/>allocate no time allocated to real-time tasks.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CpuRealtimeRuntime")]
    public long? CpuRealtimeRuntime { get; set; } = default!;

    /// <summary>
    /// CPUs in which to allow execution (e.g., `0-3`, `0,1`).
    /// <br/>
    /// </summary>

    [JsonPropertyName("CpusetCpus")]
    public string? CpusetCpus { get; set; } = default!;

    /// <summary>
    /// Memory nodes (MEMs) in which to allow execution (0-3, 0,1). Only
    /// <br/>effective on NUMA systems.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CpusetMems")]
    public string? CpusetMems { get; set; } = default!;

    /// <summary>
    /// A list of devices to add to the container.
    /// </summary>

    [JsonPropertyName("Devices")]
    public ICollection<DeviceMapping>? Devices { get; set; } = default!;

    /// <summary>
    /// a list of cgroup rules to apply to the container
    /// </summary>

    [JsonPropertyName("DeviceCgroupRules")]
    public ICollection<string>? DeviceCgroupRules { get; set; } = default!;

    /// <summary>
    /// A list of requests for devices to be sent to device drivers.
    /// <br/>
    /// </summary>

    [JsonPropertyName("DeviceRequests")]
    public ICollection<DeviceRequest>? DeviceRequests { get; set; } = default!;

    /// <summary>
    /// Hard limit for kernel TCP buffer memory (in bytes). Depending on the
    /// <br/>OCI runtime in use, this option may be ignored. It is no longer supported
    /// <br/>by the default (runc) runtime.
    /// <br/>
    /// <br/>This field is omitted when empty.
    /// <br/>
    /// </summary>

    [JsonPropertyName("KernelMemoryTCP")]
    public long? KernelMemoryTCP { get; set; } = default!;

    /// <summary>
    /// Memory soft limit in bytes.
    /// </summary>

    [JsonPropertyName("MemoryReservation")]
    public long? MemoryReservation { get; set; } = default!;

    /// <summary>
    /// Total memory limit (memory + swap). Set as `-1` to enable unlimited
    /// <br/>swap.
    /// <br/>
    /// </summary>

    [JsonPropertyName("MemorySwap")]
    public long? MemorySwap { get; set; } = default!;

    /// <summary>
    /// Tune a container's memory swappiness behavior. Accepts an integer
    /// <br/>between 0 and 100.
    /// <br/>
    /// </summary>

    [JsonPropertyName("MemorySwappiness")]
    public long? MemorySwappiness { get; set; } = default!;

    /// <summary>
    /// CPU quota in units of 10&lt;sup&gt;-9&lt;/sup&gt; CPUs.
    /// </summary>

    [JsonPropertyName("NanoCpus")]
    public long? NanoCpus { get; set; } = default!;

    /// <summary>
    /// Disable OOM Killer for the container.
    /// </summary>

    [JsonPropertyName("OomKillDisable")]
    public bool? OomKillDisable { get; set; } = default!;

    /// <summary>
    /// Run an init inside the container that forwards signals and reaps
    /// <br/>processes. This field is omitted if empty, and the default (as
    /// <br/>configured on the daemon) is used.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Init")]
    public bool? Init { get; set; } = default!;

    /// <summary>
    /// Tune a container's PIDs limit. Set `0` or `-1` for unlimited, or `null`
    /// <br/>to not change.
    /// <br/>
    /// </summary>

    [JsonPropertyName("PidsLimit")]
    public long? PidsLimit { get; set; } = default!;

    /// <summary>
    /// A list of resource limits to set in the container. For example:
    /// <br/>
    /// <br/>```
    /// <br/>{"Name": "nofile", "Soft": 1024, "Hard": 2048}
    /// <br/>```
    /// <br/>
    /// </summary>

    [JsonPropertyName("Ulimits")]
    public ICollection<Ulimits>? Ulimits { get; set; } = default!;

    /// <summary>
    /// The number of usable CPUs (Windows only).
    /// <br/>
    /// <br/>On Windows Server containers, the processor resource controls are
    /// <br/>mutually exclusive. The order of precedence is `CPUCount` first, then
    /// <br/>`CPUShares`, and `CPUPercent` last.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CpuCount")]
    public long? CpuCount { get; set; } = default!;

    /// <summary>
    /// The usable percentage of the available CPUs (Windows only).
    /// <br/>
    /// <br/>On Windows Server containers, the processor resource controls are
    /// <br/>mutually exclusive. The order of precedence is `CPUCount` first, then
    /// <br/>`CPUShares`, and `CPUPercent` last.
    /// <br/>
    /// </summary>

    [JsonPropertyName("CpuPercent")]
    public long? CpuPercent { get; set; } = default!;

    /// <summary>
    /// Maximum IOps for the container system drive (Windows only)
    /// </summary>

    [JsonPropertyName("IOMaximumIOps")]
    public long? IOMaximumIOps { get; set; } = default!;

    /// <summary>
    /// Maximum IO in bytes per second for the container system drive
    /// <br/>(Windows only).
    /// <br/>
    /// </summary>

    [JsonPropertyName("IOMaximumBandwidth")]
    public long? IOMaximumBandwidth { get; set; } = default!;


}