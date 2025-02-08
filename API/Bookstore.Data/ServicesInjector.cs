using Bookstore.Data.Repositories;
using Bookstore.Inventory;
using Bookstore.Register;
using Bookstore.Transact;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bookstore.Data;

public static class ServicesInjector
{
    public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BookstoreDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        });

        services
            .AddScoped<IInventoryRepository, BookstoreInventoryRepository>()
            .AddScoped<IBookstoreTransactRepository, BookstoreTransactRepository>()
            .AddScoped<IRegisterRepository, BookstoreRegisterRepository>();

        return services;
    }
}
