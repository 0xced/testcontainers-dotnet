using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DockerEngine;
  
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial interface IDockerPluginClient
{

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// List plugins
    /// </summary>
    /// <remarks>
    /// Returns information about installed plugins.
    /// </remarks>
    /// <param name="filters">A JSON encoded value of the filters (a `map[string][]string`) to
    /// <br/>process on the plugin list.
    /// <br/>
    /// <br/>Available filters:
    /// <br/>
    /// <br/>- `capability=&lt;capability name&gt;`
    /// <br/>- `enable=&lt;true&gt;|&lt;false&gt;`</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<IReadOnlyCollection<Plugin>> ListAsync(string? filters = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get plugin privileges
    /// </summary>
    /// <param name="remote">The name of the plugin. The `:latest` tag is optional, and is the
    /// <br/>default if omitted.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<IReadOnlyCollection<PluginPrivilege>> GetPluginPrivilegesAsync(string remote, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Install a plugin
    /// </summary>
    /// <remarks>
    /// Pulls and installs a plugin. After the plugin is installed, it can be
    /// <br/>enabled using the [`POST /plugins/{name}/enable` endpoint](#operation/PostPluginsEnable).
    /// </remarks>
    /// <param name="remote">Remote reference for plugin to install.
    /// <br/>
    /// <br/>The `:latest` tag is optional, and is used as the default if omitted.</param>
    /// <param name="name">Local name for the pulled plugin.
    /// <br/>
    /// <br/>The `:latest` tag is optional, and is used as the default if omitted.</param>
    /// <param name="x_Registry_Auth">A base64url-encoded auth configuration to use when pulling a plugin
    /// <br/>from a registry.
    /// <br/>
    /// <br/>Refer to the [authentication section](#section/Authentication) for
    /// <br/>details.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task PullAsync(string remote, string? name = null, string? x_Registry_Auth = null, IEnumerable<PluginPrivilege>? body = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Inspect a plugin
    /// </summary>
    /// <param name="name">The name of the plugin. The `:latest` tag is optional, and is the
    /// <br/>default if omitted.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<Plugin> InspectAsync(string name, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Remove a plugin
    /// </summary>
    /// <param name="name">The name of the plugin. The `:latest` tag is optional, and is the
    /// <br/>default if omitted.</param>
    /// <param name="force">Disable the plugin before removing. This may result in issues if the
    /// <br/>plugin is in use by a container.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task<Plugin> DeleteAsync(string name, bool? force = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Enable a plugin
    /// </summary>
    /// <param name="name">The name of the plugin. The `:latest` tag is optional, and is the
    /// <br/>default if omitted.</param>
    /// <param name="timeout">Set the HTTP client timeout (in seconds)</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task EnableAsync(string name, int? timeout = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Disable a plugin
    /// </summary>
    /// <param name="name">The name of the plugin. The `:latest` tag is optional, and is the
    /// <br/>default if omitted.</param>
    /// <param name="force">Force disable a plugin even if still in use.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task DisableAsync(string name, bool? force = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Upgrade a plugin
    /// </summary>
    /// <param name="name">The name of the plugin. The `:latest` tag is optional, and is the
    /// <br/>default if omitted.</param>
    /// <param name="remote">Remote reference to upgrade to.
    /// <br/>
    /// <br/>The `:latest` tag is optional, and is used as the default if omitted.</param>
    /// <param name="x_Registry_Auth">A base64url-encoded auth configuration to use when pulling a plugin
    /// <br/>from a registry.
    /// <br/>
    /// <br/>Refer to the [authentication section](#section/Authentication) for
    /// <br/>details.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task UpgradeAsync(string name, string remote, string? x_Registry_Auth = null, IEnumerable<PluginPrivilege>? body = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Create a plugin
    /// </summary>
    /// <param name="name">The name of the plugin. The `:latest` tag is optional, and is the
    /// <br/>default if omitted.</param>
    /// <param name="tarContext">Path to tar containing plugin rootfs and manifest</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task CreateAsync(string name, Stream tarContext = null, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Push a plugin
    /// </summary>
    /// <remarks>
    /// Push a plugin to the registry.
    /// </remarks>
    /// <param name="name">The name of the plugin. The `:latest` tag is optional, and is the
    /// <br/>default if omitted.</param>
    /// <returns>no error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task PushAsync(string name, CancellationToken cancellationToken = default);


    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Configure a plugin
    /// </summary>
    /// <param name="name">The name of the plugin. The `:latest` tag is optional, and is the
    /// <br/>default if omitted.</param>
    /// <returns>No error</returns>
    /// <exception cref="DockerApiException">A server side error occurred.</exception>
    Task SetAsync(string name, IEnumerable<string>? body = null, CancellationToken cancellationToken = default);

}