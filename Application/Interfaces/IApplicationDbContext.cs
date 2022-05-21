using Domain.Entitäten;
using Domain.Entitäten.Security;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces;

public interface IApplicationDbContext
{
    DbSet<User>       User       { get; set; }
    DbSet<Consumed>   Consumed   { get; set; }
    DbSet<Day>        Day        { get; set; }
    DbSet<Dish>       Dish       { get; set; }
    DbSet<FoodStuff>  FoodStuff  { get; set; }
    DbSet<Image>      Image      { get; set; }
    DbSet<Ingredient> Ingredient { get; set; }
    DbSet<LogEntry>   LogEntry   { get; set; }

    Task<int> SaveChangesAsync();
}