namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public enum LogConfigType
{

    [System.Runtime.Serialization.EnumMember(Value = @"local")]
    Local = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"json-file")]
    JsonFile = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"syslog")]
    Syslog = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"journald")]
    Journald = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"gelf")]
    Gelf = 4,


    [System.Runtime.Serialization.EnumMember(Value = @"fluentd")]
    Fluentd = 5,


    [System.Runtime.Serialization.EnumMember(Value = @"awslogs")]
    Awslogs = 6,


    [System.Runtime.Serialization.EnumMember(Value = @"splunk")]
    Splunk = 7,


    [System.Runtime.Serialization.EnumMember(Value = @"etwlogs")]
    Etwlogs = 8,


    [System.Runtime.Serialization.EnumMember(Value = @"none")]
    None = 9,


}