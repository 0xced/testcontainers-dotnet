namespace Testcontainers.JanusGraph;

public sealed class JanusGraphContainerTest(ITestOutputHelper testOutputHelper) : ContainerTest<JanusGraphBuilder, JanusGraphContainer>(testOutputHelper)
{
    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public async Task InsertedVertexCanBeFound()
    {
        // Given
        var label = Guid.NewGuid().ToString("D");

        using var client = new GremlinClient(new GremlinServer(Container.Hostname, Container.GetMappedPublicPort(JanusGraphBuilder.JanusGraphPort)), new JanusGraphGraphSONMessageSerializer());

        using var connection = new DriverRemoteConnection(client);

        var graphTraversalSource = AnonymousTraversalSource.Traversal().WithRemote(connection);

        // When
        await graphTraversalSource.AddV(label).Promise(traversal => traversal.Iterate())
            .ConfigureAwait(true);

        var count = await graphTraversalSource.V().HasLabel(label).Count().Promise(traversal => traversal.Next())
            .ConfigureAwait(true);

        // Then
        Assert.Equal(1, count);
    }
}