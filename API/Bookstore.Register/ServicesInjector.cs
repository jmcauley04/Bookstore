using Bookstore.Register.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Bookstore.Register;

public static class ServicesInjector
{
    public static IServiceCollection AddRegisterServices(this IServiceCollection services)
    {
        services
            .AddScoped<RegisterFactory>()
            .AddScoped<IUpdateRegister, RegisterService>();

        return services;
    }
}
