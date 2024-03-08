using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EncryptionConfig
{
    /// <summary>
    /// If set, generate a key and use it to lock data stored on the
    /// <br/>managers.
    /// <br/>
    /// </summary>

    [JsonPropertyName("AutoLockManagers")]
    public bool? AutoLockManagers { get; set; } = default!;


}