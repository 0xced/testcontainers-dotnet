using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DockerEngine;
  
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial interface IDockerSessionClient
{

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Initialize interactive session
    /// </summary>
    /// <remarks>
    /// Start a new interactive session with a server. Session allows server to
    /// <br/>call back to the client for advanced capabilities.
    /// <br/>
    /// <br/>### Hijacking
    /// <br/>
    /// <br/>This endpoint hijacks the HTTP connection to HTTP2 transport that allows
    /// <br/>the client to expose gPRC services on that connection.
    /// <br/>
    /// <br/>For example, the client sends this request to upgrade the connection:
    /// <br/>
    /// <br/>```
    /// <br/>POST /session HTTP/1.1
    /// <br/>Upgrade: h2c
    /// <br/>Connection: Upgrade
    /// <br/>```
    /// <br/>
    /// <br/>The Docker daemon responds with a `101 UPGRADED` response follow with
    /// <br/>the raw stream:
    /// <br/>
    /// <br/>```
    /// <br/>HTTP/1.1 101 UPGRADED
    /// <br/>Connection: Upgrade
    /// <br/>Upgrade: h2c
    /// <br/>```
    /// </remarks>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task SessionAsync(CancellationToken cancellationToken = default);

}