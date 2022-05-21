using Domain.Entitäten;
using Domain.Entitäten.Security;
using Microsoft.EntityFrameworkCore;

namespace Frontend.Data;

public class DataContext : DbContext
{
    public DataContext() { }

    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<User>       User       { get; set; }
    public DbSet<Consumed>   Consumed   { get; set; }
    public DbSet<Day>        Day        { get; set; }
    public DbSet<Dish>       Dish      { get; set; }
    public DbSet<FoodStuff>  FoodStuff  { get; set; }
    public DbSet<Image>      Image      { get; set; }
    public DbSet<Ingredient> Ingredient { get; set; }
    public DbSet<LogEntry>   LogEntry  { get; set; }
}