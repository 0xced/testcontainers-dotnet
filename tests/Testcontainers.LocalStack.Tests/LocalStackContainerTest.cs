namespace Testcontainers.LocalStack;

public abstract class LocalStackContainerTest(LocalStackContainerTest.LocalStackFixture localStackFixture)
{
    private const string AwsService = "Service";

    static LocalStackContainerTest()
    {
        Environment.SetEnvironmentVariable("AWS_ACCESS_KEY_ID", CommonCredentials.AwsAccessKey);
        Environment.SetEnvironmentVariable("AWS_SECRET_ACCESS_KEY", CommonCredentials.AwsSecretKey);
    }

    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    [Trait(AwsService, "cloudwatch")]
    public async Task CreateLogReturnsHttpStatusCodeOk()
    {
        // Given
        var config = new AmazonCloudWatchLogsConfig();
        config.ServiceURL = localStackFixture.Container.GetConnectionString();

        using var client = new AmazonCloudWatchLogsClient(config);

        var logGroupRequest = new CreateLogGroupRequest(Guid.NewGuid().ToString("D"));

        // When
        var logGroupResponse = await client.CreateLogGroupAsync(logGroupRequest)
            .ConfigureAwait(true);

        // Then
        Assert.Equal(HttpStatusCode.OK, logGroupResponse.HttpStatusCode);
    }

    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    [Trait(AwsService, "dynamodb")]
    public async Task GetItemReturnsPutItem()
    {
        // Given
        var id = Guid.NewGuid().ToString("D");

        var tableName = Guid.NewGuid().ToString("D");

        var config = new AmazonDynamoDBConfig();
        config.ServiceURL = localStackFixture.Container.GetConnectionString();

        using var client = new AmazonDynamoDBClient(config);

        var tableRequest = new CreateTableRequest();
        tableRequest.TableName = tableName;
        tableRequest.AttributeDefinitions = new List<AttributeDefinition> { new AttributeDefinition("Id", ScalarAttributeType.S) };
        tableRequest.KeySchema = new List<KeySchemaElement> { new KeySchemaElement("Id", KeyType.HASH) };
        tableRequest.ProvisionedThroughput = new ProvisionedThroughput(10, 5);

        var putItemRequest = new PutItemRequest();
        putItemRequest.TableName = tableName;
        putItemRequest.Item = new Dictionary<string, AttributeValue> { { "Id", new AttributeValue { S = id } } };

        var getItemRequest = new GetItemRequest();
        getItemRequest.TableName = tableName;
        getItemRequest.Key = new Dictionary<string, AttributeValue> { { "Id", new AttributeValue { S = id } } };

        // When
        _ = await client.CreateTableAsync(tableRequest)
            .ConfigureAwait(true);

        _ = await client.PutItemAsync(putItemRequest)
            .ConfigureAwait(true);

        var itemResponse = await client.GetItemAsync(getItemRequest)
            .ConfigureAwait(true);

        // Then
        Assert.Equal(id, itemResponse.Item.Values.Single().S);
    }

    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    [Trait(AwsService, "s3")]
    public async Task ListBucketsReturnsHttpStatusCodeOk()
    {
        // Given
        var config = new AmazonS3Config();
        config.ServiceURL = localStackFixture.Container.GetConnectionString();

        using var client = new AmazonS3Client(config);

        // When
        var buckets = await client.ListBucketsAsync()
            .ConfigureAwait(true);

        // Then
        Assert.Equal(HttpStatusCode.OK, buckets.HttpStatusCode);
    }

    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    [Trait(AwsService, "sns")]
    public async Task CreateTopicReturnsHttpStatusCodeOk()
    {
        // Given
        var config = new AmazonSimpleNotificationServiceConfig();
        config.ServiceURL = localStackFixture.Container.GetConnectionString();

        using var client = new AmazonSimpleNotificationServiceClient(config);

        // When
        var topicResponse = await client.CreateTopicAsync(Guid.NewGuid().ToString("D"))
            .ConfigureAwait(true);

        // Then
        Assert.Equal(HttpStatusCode.OK, topicResponse.HttpStatusCode);
    }

    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    [Trait(AwsService, "sqs")]
    public async Task CreateQueueReturnsHttpStatusCodeOk()
    {
        // Given
        var config = new AmazonSQSConfig();
        config.ServiceURL = localStackFixture.Container.GetConnectionString();

        using var client = new AmazonSQSClient(config);

        // When
        var queueResponse = await client.CreateQueueAsync(Guid.NewGuid().ToString("D"))
            .ConfigureAwait(true);

        // Then
        Assert.Equal(HttpStatusCode.OK, queueResponse.HttpStatusCode);
    }

    [UsedImplicitly]
    public sealed class LocalStackDefaultConfiguration(LocalStackFixture fixture) : LocalStackContainerTest(fixture), IClassFixture<LocalStackFixture>;

    [UsedImplicitly]
    public sealed class LocalStackV1Configuration(LocalStackV1Fixture fixture) : LocalStackContainerTest(fixture), IClassFixture<LocalStackV1Fixture>;

    public class LocalStackFixture(IMessageSink messageSink) : ContainerFixture<LocalStackBuilder, LocalStackContainer>(messageSink);

    public class LocalStackV1Fixture(IMessageSink messageSink) : LocalStackFixture(messageSink)
    {
        protected override LocalStackBuilder Configure(LocalStackBuilder builder) => builder.WithImage("localstack/localstack:1.4");
    }
}