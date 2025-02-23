namespace Testcontainers.Snowflake;

/// <inheritdoc cref="ContainerConfiguration" />
[PublicAPI]
public sealed class SnowflakeConfiguration : ContainerConfiguration
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SnowflakeConfiguration" /> class.
    /// </summary>
    public SnowflakeConfiguration()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SnowflakeConfiguration" /> class.
    /// </summary>
    /// <param name="resourceConfiguration">The Docker resource configuration.</param>
    public SnowflakeConfiguration(IResourceConfiguration<CreateContainerParameters> resourceConfiguration)
        : base(resourceConfiguration)
    {
        // Passes the configuration upwards to the base implementations to create an updated immutable copy.
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SnowflakeConfiguration" /> class.
    /// </summary>
    /// <param name="resourceConfiguration">The Docker resource configuration.</param>
    public SnowflakeConfiguration(IContainerConfiguration resourceConfiguration)
        : base(resourceConfiguration)
    {
        // Passes the configuration upwards to the base implementations to create an updated immutable copy.
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SnowflakeConfiguration" /> class.
    /// </summary>
    /// <param name="resourceConfiguration">The Docker resource configuration.</param>
    public SnowflakeConfiguration(SnowflakeConfiguration resourceConfiguration)
        : this(new SnowflakeConfiguration(), resourceConfiguration)
    {
        // Passes the configuration upwards to the base implementations to create an updated immutable copy.
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SnowflakeConfiguration" /> class.
    /// </summary>
    /// <param name="oldValue">The old Docker resource configuration.</param>
    /// <param name="newValue">The new Docker resource configuration.</param>
    public SnowflakeConfiguration(SnowflakeConfiguration oldValue, SnowflakeConfiguration newValue)
        : base(oldValue, newValue)
    {
    }
}