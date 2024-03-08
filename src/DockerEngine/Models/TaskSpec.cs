using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// User modifiable task configuration.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TaskSpec
{
    /// <summary>
    /// Plugin spec for the service.  *(Experimental release only.)*
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: ContainerSpec, NetworkAttachmentSpec, and PluginSpec are
    /// <br/>&gt; mutually exclusive. PluginSpec is only used when the Runtime field
    /// <br/>&gt; is set to `plugin`. NetworkAttachmentSpec is used when the Runtime
    /// <br/>&gt; field is set to `attachment`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("PluginSpec")]
    public PluginSpec? PluginSpec { get; set; } = default!;

    /// <summary>
    /// Container spec for the service.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: ContainerSpec, NetworkAttachmentSpec, and PluginSpec are
    /// <br/>&gt; mutually exclusive. PluginSpec is only used when the Runtime field
    /// <br/>&gt; is set to `plugin`. NetworkAttachmentSpec is used when the Runtime
    /// <br/>&gt; field is set to `attachment`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ContainerSpec")]
    public ContainerSpec? ContainerSpec { get; set; } = default!;

    /// <summary>
    /// Read-only spec type for non-swarm containers attached to swarm overlay
    /// <br/>networks.
    /// <br/>
    /// <br/>&lt;p&gt;&lt;br /&gt;&lt;/p&gt;
    /// <br/>
    /// <br/>&gt; **Note**: ContainerSpec, NetworkAttachmentSpec, and PluginSpec are
    /// <br/>&gt; mutually exclusive. PluginSpec is only used when the Runtime field
    /// <br/>&gt; is set to `plugin`. NetworkAttachmentSpec is used when the Runtime
    /// <br/>&gt; field is set to `attachment`.
    /// <br/>
    /// </summary>

    [JsonPropertyName("NetworkAttachmentSpec")]
    public NetworkAttachmentSpec? NetworkAttachmentSpec { get; set; } = default!;

    /// <summary>
    /// Resource requirements which apply to each individual container created
    /// <br/>as part of the service.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Resources")]
    public Resources2? Resources { get; set; } = default!;

    /// <summary>
    /// Specification for the restart policy which applies to containers
    /// <br/>created as part of this service.
    /// <br/>
    /// </summary>

    [JsonPropertyName("RestartPolicy")]
    public RestartPolicy2? RestartPolicy { get; set; } = default!;


    [JsonPropertyName("Placement")]
    public Placement? Placement { get; set; } = default!;

    /// <summary>
    /// A counter that triggers an update even if no relevant parameters have
    /// <br/>been changed.
    /// <br/>
    /// </summary>

    [JsonPropertyName("ForceUpdate")]
    public int? ForceUpdate { get; set; } = default!;

    /// <summary>
    /// Runtime is the type of runtime specified for the task executor.
    /// <br/>
    /// </summary>

    [JsonPropertyName("Runtime")]
    public string? Runtime { get; set; } = default!;

    /// <summary>
    /// Specifies which networks the service should attach to.
    /// </summary>

    [JsonPropertyName("Networks")]
    public ICollection<NetworkAttachmentConfig>? Networks { get; set; } = default!;

    /// <summary>
    /// Specifies the log driver to use for tasks created from this spec. If
    /// <br/>not present, the default one for the swarm will be used, finally
    /// <br/>falling back to the engine default if not specified.
    /// <br/>
    /// </summary>

    [JsonPropertyName("LogDriver")]
    public LogDriver? LogDriver { get; set; } = default!;


}