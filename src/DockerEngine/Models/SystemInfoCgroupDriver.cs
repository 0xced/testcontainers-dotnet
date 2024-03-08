using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public enum SystemInfoCgroupDriver
{

    [System.Runtime.Serialization.EnumMember(Value = @"cgroupfs")]
    Cgroupfs = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"systemd")]
    Systemd = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"none")]
    None = 2,


}