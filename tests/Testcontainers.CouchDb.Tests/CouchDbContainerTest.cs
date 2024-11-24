namespace Testcontainers.CouchDb;

public sealed class CouchDbContainerTest(ITestOutputHelper testOutputHelper) : ContainerTest<CouchDbBuilder, CouchDbContainer>(testOutputHelper)
{
    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public async Task PutDatabaseReturnsHttpStatusCodeCreated()
    {
        // Given
        using var client = new MyCouchClient(Container.GetConnectionString(), "db");

        // When
        var database = await client.Database.PutAsync()
            .ConfigureAwait(true);

        // Then
        Assert.Equal(HttpStatusCode.Created, database.StatusCode);
    }
}