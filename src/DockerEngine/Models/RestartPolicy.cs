using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// The behavior to apply when the container exits. The default is not to
/// <br/>restart.
/// <br/>
/// <br/>An ever increasing delay (double the previous delay, starting at 100ms) is
/// <br/>added before each restart to prevent flooding the server.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class RestartPolicy
{
    /// <summary>
    /// - Empty string means not to restart
    /// <br/>- `no` Do not automatically restart
    /// <br/>- `always` Always restart
    /// <br/>- `unless-stopped` Restart always except when the user has manually stopped the container
    /// <br/>- `on-failure` Restart only when the container exit code is non-zero
    /// <br/>
    /// </summary>

    [JsonPropertyName("Name")]
    [JsonConverter(typeof(JsonEnumMemberConverter<RestartPolicyName>))]
    public RestartPolicyName? Name { get; set; } = default!;

    /// <summary>
    /// If `on-failure` is used, the number of times to retry before giving up.
    /// <br/>
    /// </summary>

    [JsonPropertyName("MaximumRetryCount")]
    public int? MaximumRetryCount { get; set; } = default!;


}