namespace Respawn.Tests;

public sealed class RespawnTest(DbFixture db) : IClassFixture<DbFixture>, IAsyncLifetime
{
    private NpgsqlDataSource _dataSource = null!;

    public async Task InitializeAsync() => _dataSource = await db.RespawnAsync();

    public async Task DisposeAsync() => await _dataSource.DisposeAsync();

    [Theory]
    [InlineData("jane_doe", "jane@example.com", 30)]
    [InlineData("john_doe", "john@example.com", 30)]
    public async Task UsersTableContainsOneUser(string username, string email, int age)
    {
        // This test runs twice and inserts a record into the `users` table for each run.
        // The test counts the number of users and expects it to always be 1. If the database  
        // state is not clean, the assertion fails.
        await using var insert = _dataSource.CreateCommand("INSERT INTO users (username, email, age) VALUES ($1, $2, $3)");
        insert.Parameters.Add(new() { Value = username });
        insert.Parameters.Add(new() { Value = email });
        insert.Parameters.Add(new() { Value = age });

        await insert.ExecuteNonQueryAsync();

        await using var select = _dataSource.CreateCommand("SELECT COUNT(*) FROM users");
        var userCount = await select.ExecuteScalarAsync();

        Assert.Equal(1L, userCount);
    }
}