using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Wait until a container state reaches the given condition.
/// <br/>
/// <br/>Defaults to `not-running` if omitted or empty.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public enum Condition
{

    [System.Runtime.Serialization.EnumMember(Value = @"not-running")]
    NotRunning = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"next-exit")]
    NextExit = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"removed")]
    Removed = 2,


}