using Xunit.Abstractions;

namespace Testcontainers.Keycloak;

public abstract class KeycloakContainerTest(ITestOutputHelper testOutputHelper) : ContainerTest<KeycloakBuilder, KeycloakContainer>(testOutputHelper)
{
    [Fact]
    public async Task GetOpenIdEndpointReturnsHttpStatusCodeOk()
    {
        // Given
        using var httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri(Container.GetBaseAddress());

        // When
        using var response = await httpClient.GetAsync("/realms/master/.well-known/openid-configuration")
            .ConfigureAwait(true);

        // Then
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task MasterRealmIsEnabled()
    {
        // Given
        var keycloakClient = new KeycloakClient(Container.GetBaseAddress(), KeycloakBuilder.DefaultUsername, KeycloakBuilder.DefaultPassword);

        // When
        var masterRealm = await keycloakClient.GetRealmAsync("master")
            .ConfigureAwait(true);

        // Then
        Assert.True(masterRealm.Enabled);
    }

    [UsedImplicitly]
    public sealed class KeycloakDefaultConfiguration(ITestOutputHelper testOutputHelper) : KeycloakContainerTest(testOutputHelper);

    [UsedImplicitly]
    public sealed class KeycloakV25Configuration(ITestOutputHelper testOutputHelper) : KeycloakContainerTest(testOutputHelper)
    {
        protected override KeycloakBuilder Configure(KeycloakBuilder builder) => builder.WithImage("quay.io/keycloak/keycloak:25.0");
    }
}