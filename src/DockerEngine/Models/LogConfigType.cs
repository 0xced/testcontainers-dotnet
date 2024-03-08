using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public enum LogConfigType
{

    [System.Runtime.Serialization.EnumMember(Value = @"json-file")]
    JsonFile = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"syslog")]
    Syslog = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"journald")]
    Journald = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"gelf")]
    Gelf = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"fluentd")]
    Fluentd = 4,


    [System.Runtime.Serialization.EnumMember(Value = @"awslogs")]
    Awslogs = 5,


    [System.Runtime.Serialization.EnumMember(Value = @"splunk")]
    Splunk = 6,


    [System.Runtime.Serialization.EnumMember(Value = @"etwlogs")]
    Etwlogs = 7,


    [System.Runtime.Serialization.EnumMember(Value = @"none")]
    None = 8,


}