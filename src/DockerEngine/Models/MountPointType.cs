using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public enum MountPointType
{

    [System.Runtime.Serialization.EnumMember(Value = @"bind")]
    Bind = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"volume")]
    Volume = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"tmpfs")]
    Tmpfs = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"npipe")]
    Npipe = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"cluster")]
    Cluster = 4,


}