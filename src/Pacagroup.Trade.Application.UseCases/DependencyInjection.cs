using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Pacagroup.Trade.Application.UseCases
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg => { cfg.AddMaps(Assembly.GetExecutingAssembly()); });
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            return services;
        }
    }
}
