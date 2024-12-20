namespace Testcontainers.Redis;

public sealed class RedisContainerTest(RedisContainerTest.RedisFixture redisFixture) : IClassFixture<RedisContainerTest.RedisFixture>
{
    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public void ConnectionStateReturnsOpen()
    {
        using var connection = ConnectionMultiplexer.Connect(redisFixture.Container.GetConnectionString());
        Assert.True(connection.IsConnected);
    }

    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public async Task ExecScriptReturnsSuccessful()
    {
        // Given
        const string scriptContent = "return 'Hello, scripting!'";

        // When
        var execResult = await redisFixture.Container.ExecScriptAsync(scriptContent, TestContext.Current.CancellationToken)
            .ConfigureAwait(true);

        // Then
        Assert.True(0L.Equals(execResult.ExitCode), execResult.Stderr);
        Assert.True("Hello, scripting!\n".Equals(execResult.Stdout), execResult.Stdout);
        Assert.Empty(execResult.Stderr);
    }

    public class RedisFixture(IMessageSink messageSink) : ContainerFixture<RedisBuilder, RedisContainer>(messageSink)
    {
        protected override RedisBuilder Configure(RedisBuilder builder)
        {
            return builder.WithImage("redis:7-alpine");
        }
    }
}