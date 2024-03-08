using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Placement
{
    /// <summary>
    /// An array of constraint expressions to limit the set of nodes where
    /// <br/>a task can be scheduled. Constraint expressions can either use a
    /// <br/>_match_ (`==`) or _exclude_ (`!=`) rule. Multiple constraints find
    /// <br/>nodes that satisfy every expression (AND match). Constraints can
    /// <br/>match node or Docker Engine labels as follows:
    /// <br/>
    /// <br/>node attribute       | matches                        | example
    /// <br/>---------------------|--------------------------------|-----------------------------------------------
    /// <br/>`node.id`            | Node ID                        | `node.id==2ivku8v2gvtg4`
    /// <br/>`node.hostname`      | Node hostname                  | `node.hostname!=node-2`
    /// <br/>`node.role`          | Node role (`manager`/`worker`) | `node.role==manager`
    /// <br/>`node.platform.os`   | Node operating system          | `node.platform.os==windows`
    /// <br/>`node.platform.arch` | Node architecture              | `node.platform.arch==x86_64`
    /// <br/>`node.labels`        | User-defined node labels       | `node.labels.security==high`
    /// <br/>`engine.labels`      | Docker Engine's labels         | `engine.labels.operatingsystem==ubuntu-14.04`
    /// <br/>
    /// <br/>`engine.labels` apply to Docker Engine labels like operating system,
    /// <br/>drivers, etc. Swarm administrators add `node.labels` for operational
    /// <br/>purposes by using the [`node update endpoint`](#operation/NodeUpdate).
    /// <br/>
    /// </summary>

    [JsonPropertyName("Constraints")]
    public System.Collections.Generic.ICollection<string>? Constraints { get; set; } = default!;

    /// <summary>
    /// Preferences provide a way to make the scheduler aware of factors
    /// <br/>such as topology. They are provided in order from highest to
    /// <br/>lowest precedence.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Preferences")]
    public System.Collections.Generic.ICollection<Preferences>? Preferences { get; set; } = default!;

    /// <summary>
    /// Maximum number of replicas for per node (default value is 0, which
    /// <br/>is unlimited)
    /// <br/>
    /// </summary>

    [JsonPropertyName("MaxReplicas")]
    public long? MaxReplicas { get; set; } = 0L;

    /// <summary>
    /// Platforms stores all the platforms that the service's image can
    /// <br/>run on. This field is used in the platform filter for scheduling.
    /// <br/>If empty, then the platform filter is off, meaning there are no
    /// <br/>scheduling restrictions.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Platforms")]
    public System.Collections.Generic.ICollection<Platform>? Platforms { get; set; } = default!;


}