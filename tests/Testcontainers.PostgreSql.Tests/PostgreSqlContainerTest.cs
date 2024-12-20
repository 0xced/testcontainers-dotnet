namespace Testcontainers.PostgreSql;

public sealed class PostgreSqlContainerTest(PostgreSqlContainerTest.PostgreSqlFixture postgreSqlFixture) : IClassFixture<PostgreSqlContainerTest.PostgreSqlFixture>, IAsyncLifetime, IDisposable
{
    // # --8<-- [start:UsePostgreSqlContainer]
    private readonly CancellationTokenSource _cts = new CancellationTokenSource(TimeSpan.FromMinutes(1));

    async ValueTask IAsyncLifetime.InitializeAsync() => await postgreSqlFixture.Container.StartAsync(_cts.Token);

    async ValueTask IAsyncDisposable.DisposeAsync() => await postgreSqlFixture.Container.StopAsync(_cts.Token);

    void IDisposable.Dispose() => _cts.Dispose();

    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public void ConnectionStateReturnsOpen()
    {
        // Given
        using DbConnection connection = postgreSqlFixture.CreateConnection();

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
        var execResult = await postgreSqlFixture.Container.ExecScriptAsync(scriptContent, TestContext.Current.CancellationToken)
            .ConfigureAwait(true);

        // Then
        Assert.True(0L.Equals(execResult.ExitCode), execResult.Stderr);
        Assert.Empty(execResult.Stderr);
    }
    // # --8<-- [end:UsePostgreSqlContainer]

    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public void ExecuteScalarReturnsSuccessful()
    {
        // Given
        using var command = postgreSqlFixture.CreateCommand("SELECT version()");

        // When
        var result = command.ExecuteScalar() as string;

        // Then
        Assert.StartsWith("PostgreSQL 15.1", result);
    }

    public class PostgreSqlFixture(IMessageSink messageSink) : DbContainerFixture<PostgreSqlBuilder, PostgreSqlContainer>(messageSink)
    {
        public override DbProviderFactory DbProviderFactory => NpgsqlFactory.Instance;
    }
}