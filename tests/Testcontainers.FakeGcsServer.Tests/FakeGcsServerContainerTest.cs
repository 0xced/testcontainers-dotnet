namespace Testcontainers.FakeGcsServer;

public sealed class FakeGcsServerContainerTest(ITestOutputHelper testOutputHelper) : ContainerTest<FakeGcsServerBuilder, FakeGcsServerContainer>(testOutputHelper)
{
    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public async Task DownloadObjectReturnsUploadObject()
    {
        // Given
        const string helloWorld = "Hello, World!";

        using var writeStream = new MemoryStream(Encoding.Default.GetBytes(helloWorld));

        using var readStream = new MemoryStream();

        var project = Guid.NewGuid().ToString("D");

        var bucket = Guid.NewGuid().ToString("D");

        var fileName = Path.GetRandomFileName();

        var storageClientBuilder = new StorageClientBuilder();
        storageClientBuilder.UnauthenticatedAccess = true;
        storageClientBuilder.BaseUri = Container.GetConnectionString();

        // When
        var client = await storageClientBuilder.BuildAsync()
            .ConfigureAwait(true);

        _ = await client.CreateBucketAsync(project, bucket)
            .ConfigureAwait(true);

        _ = await client.UploadObjectAsync(bucket, fileName, "text/plain", writeStream)
            .ConfigureAwait(true);

        _ = await client.DownloadObjectAsync(bucket, fileName, readStream)
            .ConfigureAwait(true);

        // Then
        Assert.Equal(helloWorld, Encoding.Default.GetString(readStream.ToArray()));
    }
}