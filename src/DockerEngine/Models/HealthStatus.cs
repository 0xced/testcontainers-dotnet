using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public enum HealthStatus
{

    [System.Runtime.Serialization.EnumMember(Value = @"none")]
    None = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"starting")]
    Starting = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"healthy")]
    Healthy = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"unhealthy")]
    Unhealthy = 3,


}