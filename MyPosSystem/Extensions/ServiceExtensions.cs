using Microsoft.EntityFrameworkCore;
using MyPosSystem.Interfaces;
using MyPosSystem.Repositories;
using MyPosSystem.Interfaces;

namespace MyPosSystem.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy",
                builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
        });
    }
    public static void ConfigureIISIntegration(this IServiceCollection services)
    {
        services.Configure<IISOptions>(options =>
        {

        });
    }
    public static void ConfigureMsSqlContext(this IServiceCollection services, IConfiguration config)
    {
        //var connectionString = config["mssqlconnection:connectionString"];
        var connectionString = config["connectionString"];

        services.AddDbContext<DBContext>(o => o.UseSqlServer(connectionString, x => x.MigrationsAssembly("Entities")));
    }
    public static void ConfigureRepositoryWrapper(this IServiceCollection services)
    {
        services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
    }
}