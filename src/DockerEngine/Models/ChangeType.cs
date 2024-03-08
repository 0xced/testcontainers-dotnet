using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// Kind of change
/// <br/>
/// <br/>Can be one of:
/// <br/>
/// <br/>- `0`: Modified ("C")
/// <br/>- `1`: Added ("A")
/// <br/>- `2`: Deleted ("D")
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public enum ChangeType
{

    _0 = 0,


    _1 = 1,


    _2 = 2,


}