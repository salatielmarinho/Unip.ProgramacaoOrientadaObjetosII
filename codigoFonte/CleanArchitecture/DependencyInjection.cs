using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        },
        ServiceLifetime.Scoped);

        services.AddScoped<DataContext, DataContext>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IContatoRepository, ContatoRepository>();

        return services;
    }
}
