namespace Testcontainers.Couchbase;

public sealed class CouchbaseContainerTest(ITestOutputHelper testOutputHelper) : ContainerTest<CouchbaseBuilder, CouchbaseContainer>(testOutputHelper)
{
    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public async Task GetBucketReturnsDefaultBucket()
    {
        // Given
        var clusterOptions = new ClusterOptions();
        clusterOptions.ConnectionString = Container.GetConnectionString();
        clusterOptions.UserName = CouchbaseBuilder.DefaultUsername;
        clusterOptions.Password = CouchbaseBuilder.DefaultPassword;

        var cluster = await Cluster.ConnectAsync(clusterOptions)
            .ConfigureAwait(true);

        // When
        var ping = await cluster.PingAsync()
            .ConfigureAwait(true);

        var bucket = await cluster.BucketAsync(Container.Buckets.Single().Name)
            .ConfigureAwait(true);

        // Then
        Assert.NotEmpty(ping.Id);
        Assert.NotEmpty(ping.Services);
        Assert.NotEmpty(bucket.Name);
    }
}