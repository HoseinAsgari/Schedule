using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ScheduleDbContext>(opts =>
            {
                opts.UseSqlServer(configuration.GetConnectionString("ScheduleDbConnection"));
            });
        }
    }
}