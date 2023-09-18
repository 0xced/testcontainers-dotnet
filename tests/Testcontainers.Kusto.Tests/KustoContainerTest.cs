namespace Testcontainers.Kusto;

public sealed class KustoContainerTest : ContainerTest<KustoBuilder, KustoContainer>
{
    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public async Task ShowDatabaseReturnsDefaultDbInformation()
    {
        // Given
        using var client = KustoClientFactory.CreateCslAdminProvider(Container.GetConnectionString());

        // When
        using var dataReader = await client.ExecuteControlCommandAsync("NetDefaultDB", CslCommandGenerator.GenerateDatabaseShowCommand())
            .ConfigureAwait(false);

        _ = dataReader.Read();

        // Then
        Assert.Equal("DatabaseName", dataReader.GetName(0));
        Assert.Equal("NetDefaultDB", dataReader.GetString(0));
    }
}