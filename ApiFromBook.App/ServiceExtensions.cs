using Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiFromBook.App;

public static class ServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddCors((options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowCredentials()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        }));
    }

    public static void ConfigureSqlContext(this IServiceCollection serviceCollection,IConfiguration configuration)
    {
        serviceCollection.AddDbContext<RepositoryContext>((builder =>
        {
            builder.UseSqlServer(configuration.GetConnectionString("sqlConnection"), b =>
            {
                b.MigrationsAssembly("Company");
            });
        }));
    }
    
    
}