namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class BindOptions
{
    /// <summary>
    /// A propagation mode with the value `[r]private`, `[r]shared`, or `[r]slave`.
    /// </summary>

    [JsonPropertyName("Propagation")]
    [JsonConverter(typeof(JsonEnumMemberConverter<BindOptionsPropagation>))]
    public BindOptionsPropagation? Propagation { get; set; } = default!;

    /// <summary>
    /// Disable recursive bind mount.
    /// </summary>

    [JsonPropertyName("NonRecursive")]
    public bool? NonRecursive { get; set; } = false;

    /// <summary>
    /// Create mount point on host if missing
    /// </summary>

    [JsonPropertyName("CreateMountpoint")]
    public bool? CreateMountpoint { get; set; } = false;

    /// <summary>
    /// Make the mount non-recursively read-only, but still leave the mount recursive
    /// <br/>(unless NonRecursive is set to `true` in conjunction).
    /// <br/>
    /// <br/>Added in v1.44, before that version all read-only mounts were
    /// <br/>non-recursive by default. To match the previous behaviour this
    /// <br/>will default to `true` for clients on versions prior to v1.44.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ReadOnlyNonRecursive")]
    public bool? ReadOnlyNonRecursive { get; set; } = false;

    /// <summary>
    /// Raise an error if the mount cannot be made recursively read-only.
    /// </summary>

    [JsonPropertyName("ReadOnlyForceRecursive")]
    public bool? ReadOnlyForceRecursive { get; set; } = false;


}