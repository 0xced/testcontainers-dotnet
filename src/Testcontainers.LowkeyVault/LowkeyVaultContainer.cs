namespace Testcontainers.LowkeyVault;

/// <inheritdoc cref="DockerContainer" />
[PublicAPI]
public sealed class LowkeyVaultContainer : DockerContainer
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LowkeyVaultContainer" /> class.
    /// </summary>
    /// <param name="configuration">The container configuration.</param>
    public LowkeyVaultContainer(LowkeyVaultConfiguration configuration)
        : base(configuration)
    {
    }

    public override async Task StartAsync(CancellationToken ct = default)
    {
        await base.StartAsync(ct);

        DefaultVaultBaseUrl = new UriBuilder(Uri.UriSchemeHttps, Hostname, GetMappedPublicPort(LowkeyVaultBuilder.LowkeyVaultPort)).Uri;
        TokenEndpointUrl = new UriBuilder(Uri.UriSchemeHttp, Hostname, GetMappedPublicPort(LowkeyVaultBuilder.LowkeyVaultTokenPort), LowkeyVaultBuilder.TokenEndPointPath).Uri;

        DefaultKeyStore = await GetDefaultKeyStoreAsync();
    }

    /// <summary>
    /// The default vault base URL.
    /// </summary>
    public Uri DefaultVaultBaseUrl { get; private set; }

    /// <summary>
    /// The full token endpoint URL.
    /// </summary>
    public Uri TokenEndpointUrl { get; private set; }

    /// <summary>
    /// The certificate collection containing the default certificate shipped with Lowkey Vault.
    /// </summary>
    public X509Certificate2Collection DefaultKeyStore { get; private set; }

    /// <summary>
    /// Gets the URL of the vault with a given name.
    /// <param name="vaultName">the name of the vault.</param>
    /// </summary>
    /// <returns>The vault base URL.</returns>
    public Uri GetVaultBaseUrl(string vaultName)
    {
        // Using `localhost` here instead of `Hostname` (which resolves to `127.0.0.1` in this environment)
        // to address a compatibility issue with the Java URI parser utilized by the Lowkey Vault client. 
        // The parser fails to properly handle URIs containing a mix of DNS names and IP addresses, leading to errors. 
        // For more details, refer to: https://github.com/nagyesta/lowkey-vault/issues/1319#issuecomment-2600214768
        return new UriBuilder(Uri.UriSchemeHttps, $"{vaultName}.localhost", GetMappedPublicPort(LowkeyVaultBuilder.LowkeyVaultPort)).Uri;
    }

    /// <summary>
    /// Gets a <see cref="X509Certificate2Collection"/> containing the default certificate shipped with Lowkey Vault.
    /// </summary>
    /// <returns>The <see cref="X509Certificate2Collection"/>.</returns>
    private async Task<X509Certificate2Collection> GetDefaultKeyStoreAsync()
    {
        using var httpClient = new HttpClient();

        var passwordUri = new Uri(TokenEndpointUrl, "/metadata/default-cert/password");
        var password = await httpClient.GetStringAsync(passwordUri);

        var keyStoreUri = new Uri(TokenEndpointUrl, "/metadata/default-cert/lowkey-vault.p12");
        var keyStore = await httpClient.GetByteArrayAsync(keyStoreUri);

        // Load the PKCS12 keystore
#if NET9_0_OR_GREATER
        return X509CertificateLoader.LoadPkcs12Collection(keyStore, password, X509KeyStorageFlags.DefaultKeySet);
#else
        return [new X509Certificate2(keyStore, password, X509KeyStorageFlags.DefaultKeySet)];
#endif
    }
}