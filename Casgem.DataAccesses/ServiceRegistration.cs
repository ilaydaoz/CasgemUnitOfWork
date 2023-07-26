using Casgem.DataAccesses.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Casgem.DataAccesses
{
    public static class ServiceRegistration
    {
        public static void AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Context>(x =>
            {
                x.UseNpgsql(configuration.GetConnectionString("Context"));
            });
            services.TryAddScoped<DbContext, Context>();
        }
    }
}
