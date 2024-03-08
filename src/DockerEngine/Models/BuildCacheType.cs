using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public enum BuildCacheType
{

    [System.Runtime.Serialization.EnumMember(Value = @"internal")]
    Internal = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"frontend")]
    Frontend = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"source.local")]
    Source_local = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"source.git.checkout")]
    Source_git_checkout = 3,


    [System.Runtime.Serialization.EnumMember(Value = @"exec.cachemount")]
    Exec_cachemount = 4,


    [System.Runtime.Serialization.EnumMember(Value = @"regular")]
    Regular = 5,


}