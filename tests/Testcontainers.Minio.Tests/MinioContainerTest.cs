namespace Testcontainers.Minio;

public sealed class MinioContainerTest(ITestOutputHelper testOutputHelper) : ContainerTest<MinioBuilder, MinioContainer>(testOutputHelper)
{
    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public async Task ListBucketsReturnsHttpStatusCodeOk()
    {
        // Given
        var config = new AmazonS3Config();
        config.ServiceURL = Container.GetConnectionString();

        using var client = new AmazonS3Client(Container.GetAccessKey(), Container.GetSecretKey(), config);

        // When
        var buckets = await client.ListBucketsAsync()
            .ConfigureAwait(true);

        // Then
        Assert.Equal(HttpStatusCode.OK, buckets.HttpStatusCode);
    }

    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public async Task GetObjectReturnsPutObject()
    {
        // Given
        using var inputStream = new MemoryStream(new byte[byte.MaxValue]);

        var config = new AmazonS3Config();
        config.ServiceURL = Container.GetConnectionString();

        using var client = new AmazonS3Client(Container.GetAccessKey(), Container.GetSecretKey(), config);

        var objectRequest = new PutObjectRequest();
        objectRequest.BucketName = Guid.NewGuid().ToString("D");
        objectRequest.Key = Guid.NewGuid().ToString("D");
        objectRequest.InputStream = inputStream;

        // When
        _ = await client.PutBucketAsync(objectRequest.BucketName)
            .ConfigureAwait(true);

        _ = await client.PutObjectAsync(objectRequest)
            .ConfigureAwait(true);

        var objectResponse = await client.GetObjectAsync(objectRequest.BucketName, objectRequest.Key)
            .ConfigureAwait(true);

        // Then
        Assert.Equal(byte.MaxValue, objectResponse.ContentLength);
    }
}