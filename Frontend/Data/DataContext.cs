using Domain.Entitäten.Security;
using Microsoft.EntityFrameworkCore;

namespace Frontend.Data;

public class DataContext : DbContext
{
    public DataContext() { }

    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
}