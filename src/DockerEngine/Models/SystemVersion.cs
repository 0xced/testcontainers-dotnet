using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Response of Engine API: GET "/version"
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SystemVersion
{

    [JsonPropertyName("Platform")]
    public Platform2? Platform { get; set; } = default!;

    /// <summary>
    /// Information about system components
    /// <br/>
    /// </summary>

    [JsonPropertyName("Components")]
    public System.Collections.Generic.ICollection<Components>? Components { get; set; } = default!;

    /// <summary>
    /// The version of the daemon
    /// </summary>

    [JsonPropertyName("Version")]
    public string? Version { get; set; } = default!;

    /// <summary>
    /// The default (and highest) API version that is supported by the daemon
    /// <br/>
    /// </summary>

    [JsonPropertyName("ApiVersion")]
    public string? ApiVersion { get; set; } = default!;

    /// <summary>
    /// The minimum API version that is supported by the daemon
    /// <br/>
    /// </summary>

    [JsonPropertyName("MinAPIVersion")]
    public string? MinAPIVersion { get; set; } = default!;

    /// <summary>
    /// The Git commit of the source code that was used to build the daemon
    /// <br/>
    /// </summary>

    [JsonPropertyName("GitCommit")]
    public string? GitCommit { get; set; } = default!;

    /// <summary>
    /// The version Go used to compile the daemon, and the version of the Go
    /// <br/>runtime in use.
    /// <br/>
    /// </summary>

    [JsonPropertyName("GoVersion")]
    public string? GoVersion { get; set; } = default!;

    /// <summary>
    /// The operating system that the daemon is running on ("linux" or "windows")
    /// <br/>
    /// </summary>

    [JsonPropertyName("Os")]
    public string? Os { get; set; } = default!;

    /// <summary>
    /// The architecture that the daemon is running on
    /// <br/>
    /// </summary>

    [JsonPropertyName("Arch")]
    public string? Arch { get; set; } = default!;

    /// <summary>
    /// The kernel version (`uname -r`) that the daemon is running on.
    /// <br/>
    /// <br/>This field is omitted when empty.
    /// <br/>
    /// </summary>

    [JsonPropertyName("KernelVersion")]
    public string? KernelVersion { get; set; } = default!;

    /// <summary>
    /// Indicates if the daemon is started with experimental features enabled.
    /// <br/>
    /// <br/>This field is omitted when empty / false.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Experimental")]
    public bool? Experimental { get; set; } = default!;

    /// <summary>
    /// The date and time that the daemon was compiled.
    /// <br/>
    /// </summary>

    [JsonPropertyName("BuildTime")]
    public string? BuildTime { get; set; } = default!;


}