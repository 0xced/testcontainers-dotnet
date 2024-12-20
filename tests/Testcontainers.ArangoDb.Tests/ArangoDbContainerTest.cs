namespace Testcontainers.ArangoDb;

public sealed class ArangoDbContainerTest(ITestOutputHelper testOutputHelper) : ContainerTest<ArangoDbBuilder, ArangoDbContainer>(testOutputHelper)
{
    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public async Task RetrievesDatabases()
    {
        // Given
        var address = new Uri(Container.GetTransportAddress());

        using var transport = HttpApiTransport.UsingBasicAuth(address, ArangoDbBuilder.DefaultUsername, ArangoDbBuilder.DefaultPassword);

        using var client = new ArangoDBClient(transport);

        // When
        var response = await client.Database.GetDatabasesAsync(TestContext.Current.CancellationToken)
            .ConfigureAwait(true);

        // Then
        Assert.Equal(HttpStatusCode.OK, response.Code);
    }
}