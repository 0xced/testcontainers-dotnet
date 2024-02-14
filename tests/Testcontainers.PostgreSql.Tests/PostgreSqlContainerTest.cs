namespace Testcontainers.PostgreSql;

public abstract class PostgreSqlContainerTest(PostgreSqlContainerTest.PostgreSqlDefaultFixture fixture)
{
    // # --8<-- [start:UsePostgreSqlContainer]
    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public void ConnectionStateReturnsOpen()
    {
        // Given
        using DbConnection connection = fixture.CreateConnection();

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
        var execResult = await fixture.Container.ExecScriptAsync(scriptContent)
            .ConfigureAwait(true);

        // Then
        Assert.True(0L.Equals(execResult.ExitCode), execResult.Stderr);
        Assert.Empty(execResult.Stderr);
    }
    // # --8<-- [end:UsePostgreSqlContainer]

    public sealed class ReuseContainerTest : IClassFixture<PostgreSqlDefaultFixture>, IDisposable
    {
        private readonly CancellationTokenSource _cts = new CancellationTokenSource(TimeSpan.FromMinutes(1));

        private readonly PostgreSqlDefaultFixture _fixture;

        public ReuseContainerTest(PostgreSqlDefaultFixture fixture)
        {
            _fixture = fixture;
        }

        public void Dispose()
        {
            _cts.Dispose();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public async Task StopsAndStartsContainerSuccessful(int _)
        {
            await _fixture.Container.StopAsync(_cts.Token)
                .ConfigureAwait(true);

            await _fixture.Container.StartAsync(_cts.Token)
                .ConfigureAwait(true);

            Assert.False(_cts.IsCancellationRequested);
        }
    }

    public sealed class InitializationScriptsTest(PostgreSqlChinookInitializationFixture fixture) : IClassFixture<PostgreSqlChinookInitializationFixture>
    {
        [Theory]
        [InlineData("chinook")]
        [InlineData("chinook_auto_increment")]
        [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
        public void ChinookDatabaseIsInitialized(string database)
        {
            // Given
            var connectionStringBuilder = new NpgsqlConnectionStringBuilder(fixture.ConnectionString) { Database = database };
            using var connection = new NpgsqlConnection(connectionStringBuilder.ConnectionString);
            using var command = new NpgsqlCommand("SELECT name FROM genre WHERE genre_id = 1", connection);
            connection.Open();

            // When
            var result = command.ExecuteScalar();

            // Then
            Assert.Equal("Rock", result);
        }
    }

    public class PostgreSqlDefaultFixture(IMessageSink messageSink)
        : DbContainerFixture<PostgreSqlBuilder, PostgreSqlContainer>(messageSink)
    {
        public override DbProviderFactory DbProviderFactory
            => NpgsqlFactory.Instance;
    }

    [UsedImplicitly]
    public class PostgreSqlWaitForDatabaseFixture(IMessageSink messageSink)
        : PostgreSqlDefaultFixture(messageSink)
    {
        protected override PostgreSqlBuilder Configure(PostgreSqlBuilder builder)
            => builder.WithWaitStrategy(Wait.ForUnixContainer().UntilDatabaseIsAvailable(DbProviderFactory));
    }

    [UsedImplicitly]
    public class PostgreSqlChinookInitializationFixture(IMessageSink messageSink)
        : PostgreSqlDefaultFixture(messageSink)
    {
        protected override PostgreSqlBuilder Configure(PostgreSqlBuilder builder)
            => builder.WithInitializationScripts(
                new Uri("https://github.com/lerocha/chinook-database/releases/download/v1.4.5/Chinook_PostgreSql.sql"),
                new Uri("https://github.com/lerocha/chinook-database/releases/download/v1.4.5/Chinook_PostgreSql_AutoIncrementPKs.sql"));
    }

    [UsedImplicitly]
    public sealed class PostgreSqlDefaultConfiguration(PostgreSqlDefaultFixture fixture)
        : PostgreSqlContainerTest(fixture), IClassFixture<PostgreSqlDefaultFixture>;

    [UsedImplicitly]
    public sealed class PostgreSqlWaitForDatabaseConfiguration(PostgreSqlWaitForDatabaseFixture fixture)
        : PostgreSqlContainerTest(fixture), IClassFixture<PostgreSqlWaitForDatabaseFixture>;
}