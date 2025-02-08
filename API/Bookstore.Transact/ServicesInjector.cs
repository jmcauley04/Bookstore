using Bookstore.Transact.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Bookstore.Transact;

public static class ServicesInjector
{
    public static IServiceCollection AddTransactServices(this IServiceCollection services)
    {
        services.AddScoped<ICreateTransactions, TransactionsService>();
        return services;
    }
}
