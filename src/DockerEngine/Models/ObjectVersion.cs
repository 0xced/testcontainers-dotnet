using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// The version number of the object such as node, service, etc. This is needed
/// <br/>to avoid conflicting writes. The client must send the version number along
/// <br/>with the modified specification when updating these objects.
/// <br/>
/// <br/>This approach ensures safe concurrency and determinism in that the change
/// <br/>on the object may not be applied if the version number has changed from the
/// <br/>last read. In other words, if two update requests specify the same base
/// <br/>version, only one of the requests can succeed. As a result, two separate
/// <br/>update requests that happen at the same time will not unintentionally
/// <br/>overwrite each other.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ObjectVersion
{

    [JsonPropertyName("Index")]
    public ulong? Index { get; set; } = default!;


}