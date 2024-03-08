using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public enum RestartPolicyName
{

    [System.Runtime.Serialization.EnumMember(Value = @"")]
    Empty = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"no")]
    No = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"always")]
    Always = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"unless-stopped")]
    UnlessStopped = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"on-failure")]
    OnFailure = 4,


}