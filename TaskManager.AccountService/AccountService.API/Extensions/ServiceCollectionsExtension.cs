using AccountService.Data;
using AccountService.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Shared.Domain.Interfaces.Repositories;

namespace AccountService.API.Extensions;

public static class ServiceCollectionsExtension
{
    public static WebApplicationBuilder AddApplicationServices(this WebApplicationBuilder builder)
    {
        return builder;
    }

    public static WebApplicationBuilder AddIntegrationServices(this WebApplicationBuilder builder)
    {
        return builder;
    }

    public static WebApplicationBuilder AddRepositories(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped(typeof(IRepository<>), typeof(UserRepository));
        
        return builder;
    }

    public static WebApplicationBuilder AddDbContext(this WebApplicationBuilder builder)
    {
        builder.Services.AddPooledDbContextFactory<UsersContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQL")));
            
        return builder;
    }

    public static WebApplicationBuilder AddOpenAPI(this WebApplicationBuilder builder)
    {
        builder.Services.AddOpenApi();
        return builder;
    }
}