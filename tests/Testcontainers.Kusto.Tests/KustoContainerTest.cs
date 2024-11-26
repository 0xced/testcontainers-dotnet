namespace Testcontainers.Kusto;

public sealed class KustoContainerTest(ITestOutputHelper testOutputHelper) : ContainerTest<KustoBuilder, KustoContainer>(testOutputHelper)
{
    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public async Task ShowDatabaseReturnsDefaultDbInformation()
    {
        // Given
        using var client = KustoClientFactory.CreateCslAdminProvider(Container.GetConnectionString());

        // When
        using var dataReader = await client.ExecuteControlCommandAsync("NetDefaultDB", CslCommandGenerator.GenerateDatabaseShowCommand())
            .ConfigureAwait(true);

        _ = dataReader.Read();

        // Then
        Assert.Equal("DatabaseName", dataReader.GetName(0));
        Assert.Equal("NetDefaultDB", dataReader.GetString(0));
    }
}