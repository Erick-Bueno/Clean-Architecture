using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

public static class DependecyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString){
        services.AddDbContext<AppDbContext>(opt => opt.UseMySql(connectionString,Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.29-mysql"), m => m.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

        return services;
    }
}