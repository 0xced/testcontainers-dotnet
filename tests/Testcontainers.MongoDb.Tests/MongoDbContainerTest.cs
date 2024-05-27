namespace Testcontainers.MongoDb;

public abstract class MongoDbContainerTest(ITestOutputHelper testOutputHelper, Func<MongoDbBuilder, MongoDbBuilder> configure = null, bool replicaSetEnabled = false)
    : ContainerTest<MongoDbBuilder, MongoDbContainer>(testOutputHelper, configure)
{
    // # --8<-- [start:UseMongoDbContainer]
    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public void ConnectionStateReturnsOpen()
    {
        // Given
        var client = new MongoClient(Container.GetConnectionString());

        // When
        using var databases = client.ListDatabases();

        // Then
        Assert.Contains(databases.ToEnumerable(), database => database.TryGetValue("name", out var name) && "admin".Equals(name.AsString));
    }

    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public async Task ExecScriptReturnsSuccessful()
    {
        // Given
        const string scriptContent = "printjson(db.adminCommand({listDatabases:1,nameOnly:true,filter:{\"name\":/^admin/}}));";

        // When
        var execResult = await Container.ExecScriptAsync(scriptContent)
            .ConfigureAwait(true);

        // Then
        Assert.True(0L.Equals(execResult.ExitCode), execResult.Stderr);
        Assert.Empty(execResult.Stderr);
    }
    // # --8<-- [end:UseMongoDbContainer]

    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public async Task ReplicaSetStatus()
    {
        // Given
        const string scriptContent = "rs.status().ok;";

        // When
        var execResult = await Container.ExecScriptAsync(scriptContent)
            .ConfigureAwait(true);

        // Then
        if (replicaSetEnabled)
        {
            Assert.True(0L.Equals(execResult.ExitCode), execResult.Stderr);
            Assert.Empty(execResult.Stderr);
        }
        else
        {
            Assert.Equal(1L, execResult.ExitCode);
            Assert.Equal("MongoServerError: not running with --replSet\n", execResult.Stderr);
        }
    }

    // # --8<-- [start:CreateMongoDbContainer]
    [UsedImplicitly]
    public sealed class MongoDbDefaultConfiguration(ITestOutputHelper testOutputHelper)
        : MongoDbContainerTest(testOutputHelper);

    [UsedImplicitly]
    public sealed class MongoDbNoAuthConfiguration(ITestOutputHelper testOutputHelper)
        : MongoDbContainerTest(testOutputHelper, builder => builder.WithUsername(string.Empty).WithPassword(string.Empty));
    // # --8<-- [end:CreateMongoDbContainer]

    [UsedImplicitly]
    public sealed class MongoDbV5Configuration(ITestOutputHelper testOutputHelper)
        : MongoDbContainerTest(testOutputHelper, builder => builder.WithImage("mongo:5.0"));

    [UsedImplicitly]
    public sealed class MongoDbV4Configuration(ITestOutputHelper testOutputHelper)
        : MongoDbContainerTest(testOutputHelper, builder => builder.WithImage("mongo:4.4"), replicaSetEnabled: true /* Replica set status returns "ok" in MongoDB 4.4 without initialization. */);

    [UsedImplicitly]
    public sealed class MongoDbReplicaSetDefaultConfiguration(ITestOutputHelper testOutputHelper)
        : MongoDbContainerTest(testOutputHelper, builder => builder.WithReplicaSet(), replicaSetEnabled: true);

    // # --8<-- [start:ReplicaSetContainerConfiguration]
    [UsedImplicitly]
    public sealed class MongoDbNamedReplicaSetConfiguration(ITestOutputHelper testOutputHelper)
        : MongoDbContainerTest(testOutputHelper, builder => builder.WithReplicaSet("rs1"), replicaSetEnabled: true);
    // # --8<-- [end:ReplicaSetContainerConfiguration]
}