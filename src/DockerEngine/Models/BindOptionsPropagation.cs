using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public enum BindOptionsPropagation
{

    [System.Runtime.Serialization.EnumMember(Value = @"private")]
    Private = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"rprivate")]
    Rprivate = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"shared")]
    Shared = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"rshared")]
    Rshared = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"slave")]
    Slave = 4,


    [System.Runtime.Serialization.EnumMember(Value = @"rslave")]
    Rslave = 5,


}