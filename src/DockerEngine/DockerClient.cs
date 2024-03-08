using System.Net.Http;

namespace DockerEngine;

internal class DockerClient : IDockerClient
{
    public DockerClient(HttpClient httpClient)
    {
        Config = new DockerConfigClient(httpClient);
        Container = new DockerContainerClient(httpClient);
        Config = new DockerConfigClient(httpClient);
        Container = new DockerContainerClient(httpClient);
        Distribution = new DockerDistributionClient(httpClient);
        Exec = new DockerExecClient(httpClient);
        Image = new DockerImageClient(httpClient);
        Network = new DockerNetworkClient(httpClient);
        Node = new DockerNodeClient(httpClient);
        Plugin = new DockerPluginClient(httpClient);
        Secret = new DockerSecretClient(httpClient);
        Service = new DockerServiceClient(httpClient);
        Session = new DockerSessionClient(httpClient);
        Swarm = new DockerSwarmClient(httpClient);
        System = new DockerSystemClient(httpClient);
        Task = new DockerTaskClient(httpClient);
        Volume = new DockerVolumeClient(httpClient);
    }

    public IDockerConfigClient Config { get; }
    public IDockerContainerClient Container { get; }
    public IDockerDistributionClient Distribution { get; }
    public IDockerExecClient Exec { get; }
    public IDockerImageClient Image { get; }
    public IDockerNetworkClient Network { get; }
    public IDockerNodeClient Node { get; }
    public IDockerPluginClient Plugin { get; }
    public IDockerSecretClient Secret { get; }
    public IDockerServiceClient Service { get; }
    public IDockerSessionClient Session { get; }
    public IDockerSwarmClient Swarm { get; }
    public IDockerSystemClient System { get; }
    public IDockerTaskClient Task { get; }
    public IDockerVolumeClient Volume { get; }
}