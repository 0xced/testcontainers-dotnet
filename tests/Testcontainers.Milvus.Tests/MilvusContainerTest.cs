namespace Testcontainers.Milvus;

public abstract class MilvusContainerTest(ITestOutputHelper testOutputHelper) : ContainerTest<MilvusBuilder, MilvusContainer>(testOutputHelper)
{
    private const string MilvusVersion = "v2.3.10";

    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public async Task GetVersionReturnsExpectedVersion()
    {
        // Given
        using var client = new MilvusClient(Container.GetEndpoint());

        // When
        var version = await client.GetVersionAsync()
            .ConfigureAwait(true);

        // Then
        Assert.Equal(MilvusVersion, version);
    }

    [UsedImplicitly]
    public sealed class MilvusDefaultConfiguration(ITestOutputHelper testOutputHelper) : MilvusContainerTest(testOutputHelper)
    {
        protected override MilvusBuilder Configure(MilvusBuilder builder) => builder.WithImage("milvusdb/milvus:" + MilvusVersion);
    }

    [UsedImplicitly]
    public sealed class MilvusSidecarConfiguration(ITestOutputHelper testOutputHelper) : MilvusContainerTest(testOutputHelper)
    {
        protected override MilvusBuilder Configure(MilvusBuilder builder)
        {
            var network = new NetworkBuilder().Build();
            return builder.WithImage("milvusdb/milvus:" + MilvusVersion)
                .WithEtcdEndpoint("etcd:2379")
                .DependsOn(new ContainerBuilder()
                    .WithImage("quay.io/coreos/etcd:v3.5.5")
                    .WithNetworkAliases("etcd")
                    .WithCommand("etcd")
                    .WithCommand("-advertise-client-urls=http://127.0.0.1:2379")
                    .WithCommand("-listen-client-urls=http://0.0.0.0:2379")
                    .WithCommand("-data-dir=/etcd")
                    .WithEnvironment("ETCD_AUTO_COMPACTION_MODE", "periodic")
                    .WithEnvironment("ETCD_AUTO_COMPACTION_RETENTION", "0")
                    .WithEnvironment("ETCD_QUOTA_BACKEND_BYTES", "0")
                    .WithEnvironment("ETCD_SNAPSHOT_COUNT", "100000")
                    .WithWaitStrategy(Wait.ForUnixContainer().UntilMessageIsLogged("ready to serve client requests"))
                    .DependsOn(network)
                    .Build())
                .DependsOn(network);
        }
    }
}