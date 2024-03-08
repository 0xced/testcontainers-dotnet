using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

/// <summary>
/// PortMap describes the mapping of container ports to host ports, using the
/// <br/>container's port-number and protocol as key in the format `&lt;port&gt;/&lt;protocol&gt;`,
/// <br/>for example, `80/udp`.
/// <br/>
/// <br/>If a container's port is mapped for multiple protocols, separate entries
/// <br/>are added to the mapping table.
/// <br/>
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PortMap : Dictionary<string, List<PortBinding>?>
{

}