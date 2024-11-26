namespace Testcontainers.MySql;

public abstract class MySqlContainerTest(MySqlContainerTest.MySqlFixture mySqlFixture)
{
    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public void ConnectionStateReturnsOpen()
    {
        // Given
        using DbConnection connection = mySqlFixture.CreateConnection();

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
        var execResult = await mySqlFixture.Container.ExecScriptAsync(scriptContent)
            .ConfigureAwait(true);

        // Then
        Assert.True(0L.Equals(execResult.ExitCode), execResult.Stderr);
        Assert.Empty(execResult.Stderr);
    }

    [UsedImplicitly]
    public sealed class MySqlUserConfiguration(MySqlFixture fixture) : MySqlContainerTest(fixture), IClassFixture<MySqlFixture>;

    [UsedImplicitly]
    public sealed class MySqlRootConfiguration(MySqlRootFixture fixture) : MySqlContainerTest(fixture), IClassFixture<MySqlRootFixture>;

    [UsedImplicitly]
    // https://github.com/testcontainers/testcontainers-dotnet/issues/1142
    public sealed class GitHubIssue1142(MySqlGitHubIssue1142Fixture fixture) : MySqlContainerTest(fixture), IClassFixture<MySqlGitHubIssue1142Fixture>;

    public class MySqlFixture(IMessageSink messageSink) : DbContainerFixture<MySqlBuilder, MySqlContainer>(messageSink)
    {
        public override DbProviderFactory DbProviderFactory => MySqlConnectorFactory.Instance;
    }

    [UsedImplicitly]
    public class MySqlRootFixture(IMessageSink messageSink) : MySqlFixture(messageSink)
    {
        protected override MySqlBuilder Configure(MySqlBuilder builder) => builder.WithUsername("root");
    }

    [UsedImplicitly]
    public class MySqlGitHubIssue1142Fixture(IMessageSink messageSink) : MySqlFixture(messageSink)
    {
        protected override MySqlBuilder Configure(MySqlBuilder builder) => builder.WithImage("mysql:8.0.28");
    }
}