namespace Testcontainers.Snowflake;

public sealed class SnowflakeContainerTest(SnowflakeContainerTest.SnowflakeFixture fixture) : IClassFixture<SnowflakeContainerTest.SnowflakeFixture>
{
    [SkipIfMissingAuthTokenFact]
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

    public class SnowflakeFixture(IMessageSink messageSink)
        : DbContainerFixture<SnowflakeBuilder, SnowflakeContainer>(messageSink)
    {
        public override DbProviderFactory DbProviderFactory
            => SnowflakeDbFactory.Instance;

        protected override SnowflakeBuilder Configure(SnowflakeBuilder builder)
        {
            var authToken = Environment.GetEnvironmentVariable("LOCALSTACK_AUTH_TOKEN");
            return builder.WithImage(TestSession.GetImageFromDockerfile()).WithAuthToken(authToken);
        }
    }

    private sealed class SkipIfMissingAuthTokenFactAttribute : FactAttribute
    {
        public SkipIfMissingAuthTokenFactAttribute([CallerFilePath] string sourceFilePath = null, [CallerLineNumber] int sourceLineNumber = -1) : base(sourceFilePath, sourceLineNumber)
        {
            var authToken = Environment.GetEnvironmentVariable("LOCALSTACK_AUTH_TOKEN");
            if (authToken == null)
            {
                Skip = "The LOCALSTACK_AUTH_TOKEN environment variable is required for the Snowflake container tests.";
            }
        }
    }
}