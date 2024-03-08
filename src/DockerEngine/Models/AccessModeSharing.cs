using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public enum AccessModeSharing
{

    [System.Runtime.Serialization.EnumMember(Value = @"none")]
    None = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"readonly")]
    Readonly = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"onewriter")]
    Onewriter = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"all")]
    All = 3,


}