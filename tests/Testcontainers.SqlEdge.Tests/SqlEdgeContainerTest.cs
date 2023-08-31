namespace Testcontainers.SqlEdge;

public abstract class SqlEdgeContainerTest : IAsyncLifetime
{
    private readonly SqlEdgeContainer _sqlEdgeContainer;

    private SqlEdgeContainerTest(SqlEdgeContainer sqlEdgeContainer)
    {
        _sqlEdgeContainer = sqlEdgeContainer;
    }

    public Task InitializeAsync()
    {
        return _sqlEdgeContainer.StartAsync();
    }

    public Task DisposeAsync()
    {
        return _sqlEdgeContainer.DisposeAsync().AsTask();
    }

    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public void ConnectionStateReturnsOpen()
    {
        // Given
        using DbConnection connection = new SqlConnection(_sqlEdgeContainer.GetConnectionString());

        // When
        connection.Open();

        // Then
        Assert.Equal(ConnectionState.Open, connection.State);
    }
    
    [UsedImplicitly]
    public sealed class SqlEdgeDefault : SqlEdgeContainerTest
    {
        public SqlEdgeDefault()
            : base(new SqlEdgeBuilder().Build())
        {
        }
    }

    [UsedImplicitly]
    public sealed class SqlEdgeWaitForDatabase : SqlEdgeContainerTest
    {
        public SqlEdgeWaitForDatabase()
            : base(new SqlEdgeBuilder().WithWaitStrategy(Wait.ForUnixContainer().UntilDatabaseIsAvailable(SqlClientFactory.Instance)).Build())
        {
        }
    }
}