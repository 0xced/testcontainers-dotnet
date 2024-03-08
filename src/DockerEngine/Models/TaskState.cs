using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public enum TaskState
{

    [System.Runtime.Serialization.EnumMember(Value = @"new")]
    New = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"allocated")]
    Allocated = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"pending")]
    Pending = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"assigned")]
    Assigned = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"accepted")]
    Accepted = 4,


    [System.Runtime.Serialization.EnumMember(Value = @"preparing")]
    Preparing = 5,


    [System.Runtime.Serialization.EnumMember(Value = @"ready")]
    Ready = 6,


    [System.Runtime.Serialization.EnumMember(Value = @"starting")]
    Starting = 7,


    [System.Runtime.Serialization.EnumMember(Value = @"running")]
    Running = 8,


    [System.Runtime.Serialization.EnumMember(Value = @"complete")]
    Complete = 9,


    [System.Runtime.Serialization.EnumMember(Value = @"shutdown")]
    Shutdown = 10,


    [System.Runtime.Serialization.EnumMember(Value = @"failed")]
    Failed = 11,


    [System.Runtime.Serialization.EnumMember(Value = @"rejected")]
    Rejected = 12,


    [System.Runtime.Serialization.EnumMember(Value = @"remove")]
    Remove = 13,


    [System.Runtime.Serialization.EnumMember(Value = @"orphaned")]
    Orphaned = 14,


}