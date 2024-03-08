using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Reachability represents the reachability of a node.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public enum Reachability
{

    [System.Runtime.Serialization.EnumMember(Value = @"unknown")]
    Unknown = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"unreachable")]
    Unreachable = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"reachable")]
    Reachable = 2,


}