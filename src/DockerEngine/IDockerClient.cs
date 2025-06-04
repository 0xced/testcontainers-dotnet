namespace DockerEngine
{
    public interface IDockerClient
    {
        IDockerConfigClient Config { get; }
        IDockerContainerClient Container { get; }
        IDockerDistributionClient Distribution { get; }
        IDockerExecClient Exec { get; }
        IDockerImageClient Image { get; }
        IDockerNetworkClient Network { get; }
        IDockerNodeClient Node { get; }
        IDockerPluginClient Plugin { get; }
        IDockerSecretClient Secret { get; }
        IDockerServiceClient Service { get; }
        IDockerSessionClient Session { get; }
        IDockerSwarmClient Swarm { get; }
        IDockerSystemClient System { get; }
        IDockerTaskClient Task { get; }
        IDockerVolumeClient Volume { get; }
    }
}