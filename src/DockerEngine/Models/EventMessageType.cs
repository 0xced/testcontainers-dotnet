using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public enum EventMessageType
{

    [System.Runtime.Serialization.EnumMember(Value = @"builder")]
    Builder = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"config")]
    Config = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"container")]
    Container = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"daemon")]
    Daemon = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"image")]
    Image = 4,


    [System.Runtime.Serialization.EnumMember(Value = @"network")]
    Network = 5,


    [System.Runtime.Serialization.EnumMember(Value = @"node")]
    Node = 6,


    [System.Runtime.Serialization.EnumMember(Value = @"plugin")]
    Plugin = 7,


    [System.Runtime.Serialization.EnumMember(Value = @"secret")]
    Secret = 8,


    [System.Runtime.Serialization.EnumMember(Value = @"service")]
    Service = 9,


    [System.Runtime.Serialization.EnumMember(Value = @"volume")]
    Volume = 10,


}