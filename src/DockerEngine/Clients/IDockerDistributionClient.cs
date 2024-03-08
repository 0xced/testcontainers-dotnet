using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DockerEngine;
  
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial interface IDockerDistributionClient
{

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get image information from the registry
    /// </summary>
    /// <remarks>
    /// Return image digest and platform information by contacting the registry.
    /// </remarks>
    /// <param name="name">Image name or id</param>
    /// <returns>descriptor and platform information</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<DistributionInspect> InspectAsync(string name, CancellationToken cancellationToken = default);

}