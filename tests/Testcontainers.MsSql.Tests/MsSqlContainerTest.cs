namespace Testcontainers.MsSql;

public abstract class MsSqlContainerTest : IAsyncLifetime
{
    private readonly MsSqlContainer _msSqlContainer;

    private MsSqlContainerTest(MsSqlContainer msSqlContainer)
    {
        _msSqlContainer = msSqlContainer;
    }

    public Task InitializeAsync()
    {
        return _msSqlContainer.StartAsync();
    }

    public Task DisposeAsync()
    {
        return _msSqlContainer.DisposeAsync().AsTask();
    }

    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public void ConnectionStateReturnsOpen()
    {
        // Given
        using DbConnection connection = new SqlConnection(_msSqlContainer.GetConnectionString());

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
        var execResult = await _msSqlContainer.ExecScriptAsync(scriptContent)
            .ConfigureAwait(true);

        // When
        Assert.True(0L.Equals(execResult.ExitCode), execResult.Stderr);
    }

    [UsedImplicitly]
    public sealed class MsSqlDefault : MsSqlContainerTest
    {
        public MsSqlDefault()
            : base(new MsSqlBuilder().Build())
        {
        }
    }

    [UsedImplicitly]
    public sealed class MsSqlWaitForDatabase : MsSqlContainerTest
    {
        public MsSqlWaitForDatabase()
            : base(new MsSqlBuilder().WithWaitStrategy(Wait.ForUnixContainer().UntilDatabaseIsAvailable(SqlClientFactory.Instance)).Build())
        {
        }
    }
}