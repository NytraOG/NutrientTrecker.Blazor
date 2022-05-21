using Application.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DataContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"), b => b.MigrationsAssembly(typeof(DataContext).Assembly.FullName)), ServiceLifetime.Transient);
        services.AddScoped<IApplicationDbContext>(provider => provider.GetService<DataContext>());
    }
}