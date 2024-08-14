namespace Testcontainers.ActiveMq;

public abstract class ArtemisContainerTest(ITestOutputHelper testOutputHelper, string userName, string password, Func<ArtemisBuilder, ArtemisBuilder> configure = null)
    : ContainerTest<ArtemisBuilder, ArtemisContainer>(testOutputHelper, configure)
{
    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public async Task EstablishesConnection()
    {
        // Given
        var connectionFactory = new ConnectionFactory(Container.GetBrokerAddress());
        connectionFactory.UserName = userName;
        connectionFactory.Password = password;

        // When
        using var connection = await connectionFactory.CreateConnectionAsync()
            .ConfigureAwait(true);

        await connection.StartAsync()
            .ConfigureAwait(true);

        Assert.True(connection.IsStarted);

        // Then
        using var session = await connection.CreateSessionAsync()
            .ConfigureAwait(true);

        using var queue = await session.CreateTemporaryQueueAsync()
            .ConfigureAwait(true);

        using var producer = await session.CreateProducerAsync(queue)
            .ConfigureAwait(true);

        using var consumer = await session.CreateConsumerAsync(queue)
            .ConfigureAwait(true);

        var producedMessage = await producer.CreateTextMessageAsync(Guid.NewGuid().ToString("D"))
            .ConfigureAwait(true);

        await producer.SendAsync(producedMessage)
            .ConfigureAwait(true);

        var receivedMessage = await consumer.ReceiveAsync()
            .ConfigureAwait(true);

        Assert.Equal(producedMessage.Text, receivedMessage.Body<string>());
    }

    [UsedImplicitly]
    public sealed class DefaultCredentialsConfiguration(ITestOutputHelper testOutputHelper)
        : ArtemisContainerTest(testOutputHelper, ArtemisBuilder.DefaultUsername, ArtemisBuilder.DefaultPassword);

    [UsedImplicitly]
    public sealed class CustomCredentialsConfiguration(ITestOutputHelper testOutputHelper)
        : ArtemisContainerTest(testOutputHelper, Username, Password, builder => builder.WithUsername(Username).WithPassword(Password))
    {
        private static readonly string Username = Guid.NewGuid().ToString("D");

        private static readonly string Password = Guid.NewGuid().ToString("D");
    }

    [UsedImplicitly]
    public sealed class NoAuthCredentialsConfiguration(ITestOutputHelper testOutputHelper)
        : ArtemisContainerTest(testOutputHelper, string.Empty, string.Empty, builder => builder.WithEnvironment("ANONYMOUS_LOGIN", bool.TrueString));
}