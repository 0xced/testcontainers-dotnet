using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Current local status of this node.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public enum LocalNodeState
{

    [System.Runtime.Serialization.EnumMember(Value = @"")]
    Empty = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"inactive")]
    Inactive = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"pending")]
    Pending = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"active")]
    Active = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"error")]
    Error = 4,


    [System.Runtime.Serialization.EnumMember(Value = @"locked")]
    Locked = 5,


}