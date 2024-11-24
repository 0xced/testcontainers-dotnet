namespace Testcontainers.Elasticsearch;

// # --8<-- [start:UseElasticsearchContainer]
public sealed class ElasticsearchContainerTest(ITestOutputHelper testOutputHelper) : ContainerTest<ElasticsearchBuilder, ElasticsearchContainer>(testOutputHelper)
{
    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public void PingReturnsValidResponse()
    {
        // Given
        var clientSettings = new ElasticsearchClientSettings(new Uri(Container.GetConnectionString()));
        clientSettings.ServerCertificateValidationCallback(CertificateValidations.AllowAll);

        var client = new ElasticsearchClient(clientSettings);

        // When
        var response = client.Ping();

        // Then
        Assert.True(response.IsValidResponse);
    }
}
// # --8<-- [end:UseElasticsearchContainer]