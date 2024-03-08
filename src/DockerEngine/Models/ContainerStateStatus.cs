using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public enum ContainerStateStatus
{

    [System.Runtime.Serialization.EnumMember(Value = @"created")]
    Created = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"running")]
    Running = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"paused")]
    Paused = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"restarting")]
    Restarting = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"removing")]
    Removing = 4,


    [System.Runtime.Serialization.EnumMember(Value = @"exited")]
    Exited = 5,


    [System.Runtime.Serialization.EnumMember(Value = @"dead")]
    Dead = 6,


}