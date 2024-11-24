namespace Testcontainers.Firestore;

public sealed class FirestoreContainerTest(ITestOutputHelper testOutputHelper) : ContainerTest<FirestoreBuilder, FirestoreContainer>(testOutputHelper)
{
    [Fact]
    [Trait(nameof(DockerCli.DockerPlatform), nameof(DockerCli.DockerPlatform.Linux))]
    public async Task GetSnapshotReturnsSetDocument()
    {
        // Given
        const string collection = "db";

        var projectId = Guid.NewGuid().ToString("D");

        var documentId = Guid.NewGuid().ToString("D");

        var documentData = new Dictionary<string, string>();
        documentData.Add("id", documentId);

        var firestoreDbBuilder = new FirestoreDbBuilder();
        firestoreDbBuilder.ProjectId = projectId;
        firestoreDbBuilder.Endpoint = Container.GetEmulatorEndpoint();
        firestoreDbBuilder.ChannelCredentials = ChannelCredentials.Insecure;

        var firestoreDb = await firestoreDbBuilder.BuildAsync()
            .ConfigureAwait(true);

        // When
        _ = await firestoreDb.Collection(collection).Document().SetAsync(documentData)
            .ConfigureAwait(true);

        var querySnapshot = await firestoreDb.Collection(collection).GetSnapshotAsync()
            .ConfigureAwait(true);

        // Then
        Assert.Equal(documentData, querySnapshot.Documents.Select(document => document.ConvertTo<Dictionary<string, string>>()).Single());
    }
}