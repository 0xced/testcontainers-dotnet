using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Raft
{
    /// <summary>
    /// The number of log entries between snapshots.
    /// </summary>

    [JsonPropertyName("SnapshotInterval")]
    public ulong? SnapshotInterval { get; set; } = default!;

    /// <summary>
    /// The number of snapshots to keep beyond the current snapshot.
    /// <br/>
    /// </summary>

    [JsonPropertyName("KeepOldSnapshots")]
    public ulong? KeepOldSnapshots { get; set; } = default!;

    /// <summary>
    /// The number of log entries to keep around to sync up slow followers
    /// <br/>after a snapshot is created.
    /// <br/>
    /// </summary>

    [JsonPropertyName("LogEntriesForSlowFollowers")]
    public ulong? LogEntriesForSlowFollowers { get; set; } = default!;

    /// <summary>
    /// The number of ticks that a follower will wait for a message from
    /// <br/>the leader before becoming a candidate and starting an election.
    /// <br/>`ElectionTick` must be greater than `HeartbeatTick`.
    /// <br/>
    /// <br/>A tick currently defaults to one second, so these translate
    /// <br/>directly to seconds currently, but this is NOT guaranteed.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ElectionTick")]
    public int? ElectionTick { get; set; } = default!;

    /// <summary>
    /// The number of ticks between heartbeats. Every HeartbeatTick ticks,
    /// <br/>the leader will send a heartbeat to the followers.
    /// <br/>
    /// <br/>A tick currently defaults to one second, so these translate
    /// <br/>directly to seconds currently, but this is NOT guaranteed.
    /// <br/>
    /// </summary>

    [JsonPropertyName("HeartbeatTick")]
    public int? HeartbeatTick { get; set; } = default!;


}