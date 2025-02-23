namespace Testcontainers.Snowflake;

public sealed class SnowflakeContainerTest(ITestOutputHelper testOutputHelper) : DbContainerTest<SnowflakeBuilder, SnowflakeContainer>(testOutputHelper)
{
    public override DbProviderFactory DbProviderFactory => SnowflakeDbFactory.Instance;

    protected override SnowflakeBuilder Configure(SnowflakeBuilder builder)
    {
        var authToken = Environment.GetEnvironmentVariable("TESTCONTAINERS_SNOWFLAKE_LOCALSTACK_AUTH_TOKEN");
        Skip.If(authToken == null, "The TESTCONTAINERS_SNOWFLAKE_LOCALSTACK_AUTH_TOKEN environment variable is required for the Snowflake container tests.");
        return builder.WithAuthToken(authToken);
    }

    [SkippableFact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public void ConnectionStateReturnsOpen()
    {
        // Given
        using DbConnection connection = CreateConnection();

        // When
        connection.Open();

        // Then
        Assert.Equal(ConnectionState.Open, connection.State);
    }
}