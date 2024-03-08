using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// NodeState represents the state of a node.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public enum NodeState
{

    [System.Runtime.Serialization.EnumMember(Value = @"unknown")]
    Unknown = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"down")]
    Down = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"ready")]
    Ready = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"disconnected")]
    Disconnected = 3,


}