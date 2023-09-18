namespace Testcontainers.Kafka;

public sealed class KafkaContainerTest : ContainerTest<KafkaBuilder, KafkaContainer>
{
    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public async Task ConsumerReturnsProducerMessage()
    {
        // Given
        const string topic = "sample";

        var bootstrapServer = Container.GetBootstrapAddress();

        var producerConfig = new ProducerConfig();
        producerConfig.BootstrapServers = bootstrapServer;

        var consumerConfig = new ConsumerConfig();
        consumerConfig.BootstrapServers = bootstrapServer;
        consumerConfig.GroupId = "sample-consumer";
        consumerConfig.AutoOffsetReset = AutoOffsetReset.Earliest;

        var message = new Message<string, string>();
        message.Value = Guid.NewGuid().ToString("D");

        // When
        ConsumeResult<string, string> result;

        using (var producer = new ProducerBuilder<string, string>(producerConfig).Build())
        {
            _ = await producer.ProduceAsync(topic, message)
                .ConfigureAwait(false);
        }

        using (var consumer = new ConsumerBuilder<string, string>(consumerConfig).Build())
        {
            consumer.Subscribe(topic);
            result = consumer.Consume(TimeSpan.FromSeconds(15));
        }

        // Then
        Assert.NotNull(result);
        Assert.Equal(message.Value, result.Message.Value);
    }
}