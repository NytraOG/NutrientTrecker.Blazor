using System;
using Application.Interfaces;
using Domain.Entitäten;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Application.Tests;

public static class TestUtils
{
    public static MemoryDbContext CreateMemoryContext()
    {
        try
        {
            var connection = new SqliteConnection("Filename=:memory:");
            connection.Open();

            var contextOptions = new DbContextOptionsBuilder<MemoryDbContext>()
                                .UseSqlite(connection)
                                .Options;

            var context = new MemoryDbContext(contextOptions);

            if (context.Database.EnsureCreated())
            {
                using var viewCommand = context.Database.GetDbConnection().CreateCommand();

                viewCommand.CommandText = @"
CREATE VIEW AllResources AS
SELECT *
FROM Foodstuff;";
                viewCommand.ExecuteNonQuery();
            }

            return context;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            throw;
        }
    }
}