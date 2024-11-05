using Microsoft.EntityFrameworkCore;
using SPM.Storage.Context;
using Testcontainers.PostgreSql;

namespace SPM.Storage.Tests.Fixture;

public class StorageTestFixture : IAsyncLifetime
{
    
    private readonly PostgreSqlContainer _dbContainer = new PostgreSqlBuilder().Build();

    public DbSPMContext GetDbContext() => new(new DbContextOptionsBuilder<DbSPMContext>()
        .UseNpgsql(_dbContainer.GetConnectionString()).Options);

    public async Task InitializeAsync()
    {
        await _dbContainer.StartAsync();

        var dbContext = new DbSPMContext(new DbContextOptionsBuilder<DbSPMContext>()
            .UseNpgsql(_dbContainer.GetConnectionString()).Options);

        await dbContext.Database.MigrateAsync();
    }

    public async Task DisposeAsync()=> await _dbContainer.DisposeAsync();

}
