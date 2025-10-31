using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pacagroup.Trade.Persistence.Contexts;
using Pacagroup.Trade.Persistence.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacagroup.Trade.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<AuditableEntitySaveChangesInterceptor>();
            services.AddDbContext<AplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("TradingConnection"),
                    b => b.MigrationsAssembly(typeof(AplicationDbContext).Assembly.FullName)
                )
            );
            return services;
        }
    }
}
