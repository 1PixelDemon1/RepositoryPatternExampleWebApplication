using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using GameStore.Infrastructure.Data;
using GameStore.Application.Repository;
using GameStore.Infrastructure.RemoteRepository.HttpHandler;

namespace GameStore.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            
            services.AddDbContext<GameStoreDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });
            // Fixes tiny bug with DateTime Postgres values.
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            services.AddHttpClient();
            services.AddScoped<IHttpHandler, HttpHandler>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
