using Bookstore.Inventory.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Bookstore.Inventory;

public static class ServicesInjector
{
    public static IServiceCollection AddInventoryServices(this IServiceCollection services)
    {
        services
            .AddScoped<IAdjustInventory, InventoryService>()
            .AddScoped<BookstoreInventory>();

        return services;
    }
}
