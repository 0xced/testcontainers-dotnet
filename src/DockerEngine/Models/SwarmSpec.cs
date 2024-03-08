using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// User modifiable swarm configuration.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SwarmSpec
{
    /// <summary>
    /// Name of the swarm.
    /// </summary>

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;

    /// <summary>
    /// User-defined key/value metadata.
    /// </summary>

    [JsonPropertyName("Labels")]
    public System.Collections.Generic.IDictionary<string, string>? Labels { get; set; } = default!;

    /// <summary>
    /// Orchestration configuration.
    /// </summary>

    [JsonPropertyName("Orchestration")]
    public Orchestration? Orchestration { get; set; } = default!;

    /// <summary>
    /// Raft configuration.
    /// </summary>

    [JsonPropertyName("Raft")]
    public Raft? Raft { get; set; } = default!;

    /// <summary>
    /// Dispatcher configuration.
    /// </summary>

    [JsonPropertyName("Dispatcher")]
    public Dispatcher? Dispatcher { get; set; } = default!;

    /// <summary>
    /// CA configuration.
    /// </summary>

    [JsonPropertyName("CAConfig")]
    public CAConfig? CAConfig { get; set; } = default!;

    /// <summary>
    /// Parameters related to encryption-at-rest.
    /// </summary>

    [JsonPropertyName("EncryptionConfig")]
    public EncryptionConfig? EncryptionConfig { get; set; } = default!;

    /// <summary>
    /// Defaults for creating tasks in this cluster.
    /// </summary>

    [JsonPropertyName("TaskDefaults")]
    public TaskDefaults? TaskDefaults { get; set; } = default!;


}