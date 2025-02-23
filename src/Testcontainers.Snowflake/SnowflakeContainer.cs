namespace Testcontainers.Snowflake;

/// <inheritdoc cref="DockerContainer" />
public sealed class SnowflakeContainer(IContainerConfiguration configuration) : DockerContainer(configuration), IDatabaseContainer
{
    /// <inheritdoc />
    public string GetConnectionString()
    {
        return $"host=snowflake.localhost.localstack.cloud;port={GetMappedPublicPort(SnowflakeBuilder.SnowflakePort)};account=test;user=test;password=test;database=test";
    }
}