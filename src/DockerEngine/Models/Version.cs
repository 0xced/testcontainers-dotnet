using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Version of the builder backend to use.
/// <br/>
/// <br/>- `1` is the first generation classic (deprecated) builder in the Docker daemon (default)
/// <br/>- `2` is [BuildKit](https://github.com/moby/buildkit)
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public enum Version
{

    [System.Runtime.Serialization.EnumMember(Value = @"1")]
    _1 = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"2")]
    _2 = 1,


}