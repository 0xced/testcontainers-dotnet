namespace Testcontainers.PostgreSql;

public abstract class PostgreSqlContainerTest : IAsyncLifetime
{
    private readonly PostgreSqlContainer _postgreSqlContainer;

    protected PostgreSqlContainerTest(PostgreSqlContainer postgreSqlContainer)
    {
        _postgreSqlContainer = postgreSqlContainer;
    }

    public Task InitializeAsync()
    {
        return _postgreSqlContainer.StartAsync();
    }

    public Task DisposeAsync()
    {
        return _postgreSqlContainer.DisposeAsync().AsTask();
    }

    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public void ConnectionStateReturnsOpen()
    {
        // Given
        using DbConnection connection = new NpgsqlConnection(_postgreSqlContainer.GetConnectionString());

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
        var execResult = await _postgreSqlContainer.ExecScriptAsync(scriptContent)
            .ConfigureAwait(true);

        // Then
        Assert.True(0L.Equals(execResult.ExitCode), execResult.Stderr);
        Assert.Empty(execResult.Stderr);
    }

    public sealed class ReuseContainerTest : IClassFixture<SharedPostgreSqlInstance>, IDisposable
    {
        private readonly CancellationTokenSource _cts = new CancellationTokenSource(TimeSpan.FromMinutes(1));

        private readonly SharedContainerInstance<PostgreSqlContainer> _fixture;

        public ReuseContainerTest(SharedPostgreSqlInstance fixture)
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

    [UsedImplicitly]
    public sealed class PostgreSqlDefaultConfiguration : PostgreSqlContainerTest
    {
        public PostgreSqlDefaultConfiguration()
            : base(new PostgreSqlBuilder().Build())
        {
        }
    }

    [UsedImplicitly]
    public sealed class PostgreSqlChinookInitialization : PostgreSqlContainerTest
    {
        public PostgreSqlChinookInitialization()
            : base(new PostgreSqlBuilder()
                .WithInitializationScripts(
                    new Uri("https://github.com/lerocha/chinook-database/releases/download/v1.4.5/Chinook_PostgreSql.sql"),
                    new Uri("https://github.com/lerocha/chinook-database/releases/download/v1.4.5/Chinook_PostgreSql_AutoIncrementPKs.sql"))
                .Build())
        {
        }

        [Theory]
        [InlineData("chinook")]
        [InlineData("chinook_auto_increment")]
        [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
        public void ChinookDatabaseIsInitialized(string database)
        {
            // Given
            var connectionStringBuilder = new NpgsqlConnectionStringBuilder(_postgreSqlContainer.GetConnectionString()) { Database = database };
            using var connection = new NpgsqlConnection(connectionStringBuilder.ConnectionString);
            using var command = new NpgsqlCommand("SELECT name FROM genre WHERE genre_id = 1", connection);
            connection.Open();

            // When
            var result = command.ExecuteScalar();

            // Then
            Assert.Equal("Rock", result);
        }
    }

    [UsedImplicitly]
    public sealed class SharedPostgreSqlInstance : SharedContainerInstance<PostgreSqlContainer>
    {
        public SharedPostgreSqlInstance()
            : base(new PostgreSqlBuilder().Build())
        {
        }
    }
}