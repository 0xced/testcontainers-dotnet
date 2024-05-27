namespace Testcontainers.MariaDb;

public abstract class MariaDbContainerTest(MariaDbContainerTest.MariaDbFixture mariaDbFixture)
{
    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public void ConnectionStateReturnsOpen()
    {
        // Given
        using DbConnection connection = mariaDbFixture.CreateConnection();

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
        var execResult = await mariaDbFixture.Container.ExecScriptAsync(scriptContent)
            .ConfigureAwait(true);

        // Then
        Assert.True(0L.Equals(execResult.ExitCode), execResult.Stderr);
        Assert.Empty(execResult.Stderr);
    }

    [UsedImplicitly]
    public sealed class MariaDbUserConfiguration(MariaDbFixture fixture) : MariaDbContainerTest(fixture), IClassFixture<MariaDbFixture>;

    [UsedImplicitly]
    public sealed class MariaDbRootConfiguration(MariaDbRootUserFixture fixture) : MariaDbContainerTest(fixture), IClassFixture<MariaDbRootUserFixture>;

    public class MariaDbFixture(IMessageSink messageSink) : DbContainerFixture<MariaDbBuilder, MariaDbContainer>(messageSink)
    {
        public override DbProviderFactory DbProviderFactory => MySqlConnectorFactory.Instance;
    }

    public class MariaDbRootUserFixture(IMessageSink messageSink) : MariaDbFixture(messageSink)
    {
        protected override MariaDbBuilder Configure(MariaDbBuilder builder) => builder.WithUsername("root");
    }
}