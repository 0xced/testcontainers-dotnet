namespace Testcontainers.PostgreSql;

public abstract class PostgreSqlContainerTest(PostgreSqlContainerTest.PostgreSqlDefaultFixture fixture)
{
    // # --8<-- [start:UsePostgreSqlContainer]
#if ADONET_CLIENT
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
#endif

    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public async Task ExecScriptReturnsSuccessful()
    {
        // Given
        const string scriptContent = "SELECT 1;";

        // When
        var execResult = await fixture.Container.ExecScriptAsync(scriptContent, TestContext.Current.CancellationToken)
            .ConfigureAwait(true);

        // Then
        Assert.True(0L.Equals(execResult.ExitCode), execResult.Stderr);
        Assert.Empty(execResult.Stderr);
    }
    // # --8<-- [end:UsePostgreSqlContainer]

    [Fact]
    public void WaitStrategyUsed()
    {
        PostgreSqlConfiguration configuration = fixture.Container.AsDynamic()._configuration;
        var waitStrategy = configuration.WaitStrategies.Last();
        IWaitUntil waitUntil = DynamicHelper.Unwrap(waitStrategy.AsDynamic()._waitUntil);
#if ADONET_CLIENT
        Assert.Equal("UntilDatabaseIsAvailable", waitUntil.GetType().Name);
#else
        Assert.Equal("Testcontainers.PostgreSql.PostgreSqlBuilder+WaitUntil", waitUntil.GetType().FullName);
#endif
    }

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

#if ADONET_CLIENT
    public class PostgreSqlDefaultFixture(IMessageSink messageSink)
        : DbContainerFixture<PostgreSqlBuilder, PostgreSqlContainer>(messageSink)
    {
        protected override PostgreSqlBuilder Configure(PostgreSqlBuilder builder)
            => builder.WithImage(TestSession.GetImageFromDockerfile());

        public override DbProviderFactory DbProviderFactory
            => NpgsqlFactory.Instance;
    }
#else
    public class PostgreSqlDefaultFixture(IMessageSink messageSink)
        : ContainerFixture<PostgreSqlBuilder, PostgreSqlContainer>(messageSink);
#endif

    [UsedImplicitly]
    public class PostgreSql92Fixture(IMessageSink messageSink) : PostgreSqlDefaultFixture(messageSink)
    {
        protected override PostgreSqlBuilder Configure(PostgreSqlBuilder builder)
            => builder.WithImage("postgres:9.2");
    }

    [UsedImplicitly]
    public sealed class PostgreSqlDefaultConfiguration(PostgreSqlDefaultFixture fixture)
        : PostgreSqlContainerTest(fixture), IClassFixture<PostgreSqlDefaultFixture>;

#if ADONET_CLIENT
    [UsedImplicitly]
    public sealed class PostgreSql92Configuration(PostgreSql92Fixture fixture)
        : PostgreSqlContainerTest(fixture), IClassFixture<PostgreSql92Fixture>;
#endif
}