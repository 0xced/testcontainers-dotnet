using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// If the `X-Registry-Auth` header is not specified, this parameter
/// <br/>indicates where to find registry authorization credentials.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public enum RegistryAuthFrom
{

    [System.Runtime.Serialization.EnumMember(Value = @"spec")]
    Spec = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"previous-spec")]
    PreviousSpec = 1,


}