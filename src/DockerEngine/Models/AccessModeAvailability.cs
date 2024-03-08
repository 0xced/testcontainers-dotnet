using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public enum AccessModeAvailability
{

    [System.Runtime.Serialization.EnumMember(Value = @"active")]
    Active = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"pause")]
    Pause = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"drain")]
    Drain = 2,


}