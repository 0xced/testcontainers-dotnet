using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public enum PublishStatusState
{

    [System.Runtime.Serialization.EnumMember(Value = @"pending-publish")]
    PendingPublish = 0,


    [System.Runtime.Serialization.EnumMember(Value = @"published")]
    Published = 1,


    [System.Runtime.Serialization.EnumMember(Value = @"pending-node-unpublish")]
    PendingNodeUnpublish = 2,


    [System.Runtime.Serialization.EnumMember(Value = @"pending-controller-unpublish")]
    PendingControllerUnpublish = 3,


}