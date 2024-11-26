namespace Testcontainers.FirebirdSql;

public abstract class FirebirdSqlContainerTest(FirebirdSqlContainerTest.FirebirdSqlFixture firebirdSqlFixture)
{
    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public void ConnectionStateReturnsOpen()
    {
        // Given
        using DbConnection connection = firebirdSqlFixture.CreateConnection();

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
        const string scriptContent = "SELECT 1 FROM RDB$DATABASE;";

        // When
        var execResult = await firebirdSqlFixture.Container.ExecScriptAsync(scriptContent)
            .ConfigureAwait(true);

        // Then
        Assert.True(0L.Equals(execResult.ExitCode), execResult.Stderr);
        Assert.Empty(execResult.Stderr);
    }

    [UsedImplicitly]
    public sealed class FirebirdSql25Sc(FirebirdSql25ScFixture fixture) : FirebirdSqlContainerTest(fixture), IClassFixture<FirebirdSql25ScFixture>;

    [UsedImplicitly]
    public sealed class FirebirdSql25Ss(FirebirdSql25SsFixture fixture) : FirebirdSqlContainerTest(fixture), IClassFixture<FirebirdSql25SsFixture>;

    [UsedImplicitly]
    public sealed class FirebirdSql30(FirebirdSql30Fixture fixture) : FirebirdSqlContainerTest(fixture), IClassFixture<FirebirdSql30Fixture>;

    [UsedImplicitly]
    public sealed class FirebirdSql40(FirebirdSql40Fixture fixture) : FirebirdSqlContainerTest(fixture), IClassFixture<FirebirdSql40Fixture>;

    [UsedImplicitly]
    public sealed class FirebirdSqlSysdba(FirebirdSqlSysdbaFixture fixture) : FirebirdSqlContainerTest(fixture), IClassFixture<FirebirdSqlSysdbaFixture>;

    public class FirebirdSqlFixture(IMessageSink messageSink) : DbContainerFixture<FirebirdSqlBuilder, FirebirdSqlContainer>(messageSink)
    {
        public override DbProviderFactory DbProviderFactory => FirebirdClientFactory.Instance;
    }

    public class FirebirdSql25ScFixture(IMessageSink messageSink) : FirebirdSqlFixture(messageSink)
    {
        protected override FirebirdSqlBuilder Configure(FirebirdSqlBuilder builder) => builder.WithImage("jacobalberty/firebird:2.5-sc");
    }

    public class FirebirdSql25SsFixture(IMessageSink messageSink) : FirebirdSqlFixture(messageSink)
    {
        protected override FirebirdSqlBuilder Configure(FirebirdSqlBuilder builder) => builder.WithImage("jacobalberty/firebird:2.5-ss");
    }

    public class FirebirdSql30Fixture(IMessageSink messageSink) : FirebirdSqlFixture(messageSink)
    {
        protected override FirebirdSqlBuilder Configure(FirebirdSqlBuilder builder) => builder.WithImage("jacobalberty/firebird:v3.0");
    }

    public class FirebirdSql40Fixture(IMessageSink messageSink) : FirebirdSqlFixture(messageSink)
    {
        protected override FirebirdSqlBuilder Configure(FirebirdSqlBuilder builder) => builder.WithImage("jacobalberty/firebird:v4.0");
    }

    public class FirebirdSqlSysdbaFixture(IMessageSink messageSink) : FirebirdSqlFixture(messageSink)
    {
        protected override FirebirdSqlBuilder Configure(FirebirdSqlBuilder builder) => builder.WithUsername("sysdba").WithPassword("some-password");
    }
}