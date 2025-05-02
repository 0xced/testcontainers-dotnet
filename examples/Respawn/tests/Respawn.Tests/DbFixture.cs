namespace Respawn.Tests;

[UsedImplicitly]
public sealed class DbFixture(IMessageSink messageSink) : DbContainerFixture<PostgreSqlBuilder, PostgreSqlContainer>(messageSink)
{
    public override DbProviderFactory DbProviderFactory => NpgsqlFactory.Instance;

    public async Task<NpgsqlDataSource> RespawnAsync()
    {
        await using var dbConnection = await OpenConnectionAsync();

        // Respawn resets the database and cleans its state. This allows tests to run without
        // interfering with each other. Instead of deleting data at the end of a test, rolling
        // back a transaction, or creating a new container instance, Respawn resets the database
        // to a clean, empty state by intelligently deleting data from tables.
        var respawnerOptions = new RespawnerOptions { DbAdapter = DbAdapter.Postgres };
        var respawner = await Respawner.CreateAsync(dbConnection, respawnerOptions);
        await respawner.ResetAsync(dbConnection);

        return NpgsqlDataSource.Create(ConnectionString);
    }

    protected override PostgreSqlBuilder Configure(PostgreSqlBuilder builder)
    {
        // Testcontainers starts the dependent database (PostgreSQL) and copies the SQL scripts
        // to the container before it starts. The PostgreSQL container runs the scripts
        // automatically during startup, creating the database schema.
        return base.Configure(builder)
            .WithImage("postgres:15-alpine")
            .WithResourceMapping("migrate/", "/docker-entrypoint-initdb.d/");
    }
}