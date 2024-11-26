namespace Testcontainers.Azurite;

public abstract class AzuriteContainerTest(AzuriteContainerTest.AzuriteFixture fixture)
{
    private readonly AzuriteContainer _azuriteContainer = fixture.Container;

    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public async Task EstablishesBlobServiceConnection()
    {
        // Give
        var client = new BlobServiceClient(_azuriteContainer.GetConnectionString());

        // When
        var properties = await client.GetPropertiesAsync()
            .ConfigureAwait(true);

        // Then
        Assert.False(HasError(properties));
    }

    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public async Task EstablishesQueueServiceConnection()
    {
        // Give
        var client = new QueueServiceClient(_azuriteContainer.GetConnectionString());

        // When
        var properties = await client.GetPropertiesAsync()
            .ConfigureAwait(true);

        // Then
        Assert.False(HasError(properties));
    }

    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public async Task EstablishesTableServiceConnection()
    {
        // Give
        var client = new TableServiceClient(_azuriteContainer.GetConnectionString());

        // When
        var properties = await client.GetPropertiesAsync()
            .ConfigureAwait(true);

        // Then
        Assert.False(HasError(properties));
    }

    private static bool HasError<TResponseEntity>(NullableResponse<TResponseEntity> response)
    {
        using (var rawResponse = response.GetRawResponse())
        {
            return rawResponse.IsError;
        }
    }

    public class AzuriteFixture(IMessageSink messageSink) : ContainerFixture<AzuriteBuilder, AzuriteContainer>(messageSink);

    [UsedImplicitly]
    public sealed class AzuriteInMemoryFixture(IMessageSink messageSink) : AzuriteFixture(messageSink)
    {
        protected override AzuriteBuilder Configure(AzuriteBuilder builder) => builder.WithInMemoryPersistence();
    }

    [UsedImplicitly]
    public sealed class AzuriteMemoryLimitFixture(IMessageSink messageSink) : AzuriteFixture(messageSink)
    {
        public const int MemoryLimitInMb = 64;

        protected override AzuriteBuilder Configure(AzuriteBuilder builder) => builder.WithInMemoryPersistence(MemoryLimitInMb);
    }

    [UsedImplicitly]
    public sealed class AzuriteDefaultConfiguration(AzuriteFixture fixture) : AzuriteContainerTest(fixture), IClassFixture<AzuriteFixture>;

    [UsedImplicitly]
    public sealed class AzuriteInMemoryConfiguration(AzuriteInMemoryFixture fixture) : AzuriteContainerTest(fixture), IClassFixture<AzuriteInMemoryFixture>;

    [UsedImplicitly]
    public sealed class AzuriteMemoryLimitConfiguration(AzuriteMemoryLimitFixture fixture) : AzuriteContainerTest(fixture), IClassFixture<AzuriteMemoryLimitFixture>
    {
        private static readonly string[] LineEndings = { "\r\n", "\n" };

        [Fact]
        public async Task MemoryLimitIsConfigured()
        {
            // Given
            var (stdout, _) = await fixture.Container.GetLogsAsync(timestampsEnabled: false)
                .ConfigureAwait(true);

            // When
            var firstLine = stdout.Split(LineEndings, StringSplitOptions.RemoveEmptyEntries).First();

            // Then
            Assert.StartsWith(string.Format(CultureInfo.InvariantCulture, "In-memory extent storage is enabled with a limit of {0:F2} MB", AzuriteMemoryLimitFixture.MemoryLimitInMb), firstLine);
        }
    }
}