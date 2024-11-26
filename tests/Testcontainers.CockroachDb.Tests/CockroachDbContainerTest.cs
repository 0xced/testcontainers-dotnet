namespace Testcontainers.CockroachDb;

public sealed class CockroachDbContainerTest(CockroachDbContainerTest.CockroachDbFixture cockroachDbFixture) : IClassFixture<CockroachDbContainerTest.CockroachDbFixture>
{
    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public void ConnectionStateReturnsOpen()
    {
        // Given
        using DbConnection connection = cockroachDbFixture.CreateConnection();

        // When
        connection.Open();

        // Then
        Assert.Equal(ConnectionState.Open, connection.State);
    }

    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public async Task ExecScriptReturnsSuccessful()
    {
        // Given
        const string scriptContent = "SELECT 1;";

        // When
        var execResult = await cockroachDbFixture.Container.ExecScriptAsync(scriptContent)
            .ConfigureAwait(true);

        // Then
        Assert.True(0L.Equals(execResult.ExitCode), execResult.Stderr);
        Assert.Empty(execResult.Stderr);
    }

    public class CockroachDbFixture(IMessageSink messageSink) : DbContainerFixture<CockroachDbBuilder, CockroachDbContainer>(messageSink)
    {
        public override DbProviderFactory DbProviderFactory => NpgsqlFactory.Instance;
    }
}