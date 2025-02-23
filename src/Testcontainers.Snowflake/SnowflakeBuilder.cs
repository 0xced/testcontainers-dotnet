namespace Testcontainers.Snowflake;

/// <inheritdoc cref="ContainerBuilder{TBuilderEntity, TContainerEntity, TConfigurationEntity}" />
public sealed class SnowflakeBuilder : ContainerBuilder<SnowflakeBuilder, SnowflakeContainer, SnowflakeConfiguration>
{
    public const ushort SnowflakePort = 4566;

    /// <summary>
    /// Initializes a new instance of the <see cref="SnowflakeBuilder" /> class.
    /// </summary>
    public SnowflakeBuilder() : this(new SnowflakeConfiguration())
    {
        DockerResourceConfiguration = Init().DockerResourceConfiguration;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SnowflakeBuilder" /> class.
    /// </summary>
    /// <param name="resourceConfiguration">The Docker resource configuration.</param>
    private SnowflakeBuilder(SnowflakeConfiguration resourceConfiguration) : base(resourceConfiguration)
    {
        DockerResourceConfiguration = resourceConfiguration;
    }

    /// <inheritdoc />
    protected override SnowflakeConfiguration DockerResourceConfiguration { get; }

    /// <inheritdoc />
    protected override SnowflakeBuilder Init()
    {
        return base.Init()
            .WithImage("localstack/snowflake:0.2.5")
            .WithPortBinding(SnowflakePort, assignRandomHostPort: true)
            .WithWaitStrategy(Wait.ForUnixContainer().UntilPortIsAvailable(SnowflakePort));
    }

    /// <summary>
    /// Sets the required LocalStack auth token. Refer to the <see href="https://docs.localstack.cloud/getting-started/auth-token/">LocalStack auth token guide</see> for more information.
    /// </summary>
    /// <param name="authToken">The LocalStack auth token.</param>
    /// <returns>A configured instance of <see cref="SnowflakeBuilder" />.</returns>
    public SnowflakeBuilder WithAuthToken(string authToken)
    {
        return WithEnvironment("LOCALSTACK_AUTH_TOKEN", authToken);
    }

    /// <inheritdoc />
    public override SnowflakeContainer Build()
    {
        Validate();
        return new SnowflakeContainer(DockerResourceConfiguration);
    }

    /// <inheritdoc />
    protected override void Validate()
    {
        base.Validate();

        const string error = "A LocalStack auth token must be provided through the WithAuthToken() method. " +
                             "See https://docs.localstack.cloud/getting-started/auth-token/ for more information.";
        _ = Guard.Argument(DockerResourceConfiguration.Environments, nameof(DockerResourceConfiguration.Environments))
            .NotNull()
            .ThrowIf(argument => !argument.Value.ContainsKey("LOCALSTACK_AUTH_TOKEN"), _ => throw new ArgumentException(error));
    }

    /// <inheritdoc />
    protected override SnowflakeBuilder Clone(IResourceConfiguration<CreateContainerParameters> resourceConfiguration)
    {
        return Merge(DockerResourceConfiguration, new SnowflakeConfiguration(resourceConfiguration));
    }

    /// <inheritdoc />
    protected override SnowflakeBuilder Clone(IContainerConfiguration resourceConfiguration)
    {
        return Merge(DockerResourceConfiguration, new SnowflakeConfiguration(resourceConfiguration));
    }

    /// <inheritdoc />
    protected override SnowflakeBuilder Merge(SnowflakeConfiguration oldValue, SnowflakeConfiguration newValue)
    {
        return new SnowflakeBuilder(new SnowflakeConfiguration(oldValue, newValue));
    }
}