using Application.Interfaces;
using Domain.Entitäten;
using Domain.Entitäten.Security;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class DataContext : DbContext, IApplicationDbContext
{
    public DataContext() { }

    public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

    public DbSet<User>       User       { get; set; }
    public DbSet<Consumed>   Consumed   { get; set; }
    public DbSet<Day>        Day        { get; set; }
    public DbSet<Dish>       Dish       { get; set; }
    public DbSet<FoodStuff>  FoodStuff  { get; set; }
    public DbSet<Image>      Image      { get; set; }
    public DbSet<Ingredient> Ingredient { get; set; }
    public DbSet<LogEntry>   LogEntry   { get; set; }

    public Task<int> SaveChangesAsync() => base.SaveChangesAsync();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer("server=DESKTOP-7FA7F9C\\MSSQLSERVER2019;database=nyTEC.NutrientTrecker_Dev;trusted_connection=true");
    }
}