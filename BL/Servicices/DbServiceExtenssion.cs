using Dal.DbContext;
using Dal.DbContext.MsSql;
using Dal.Models;
using Microsoft.Extensions.DependencyInjection;

namespace BL.Servicices.Impl
{
    public static class DbServiceExtenssion
    {
        public static void AddDbService(this IServiceCollection services)
        {
            services.AddScoped<IRepository<ProviderGroup>, PGroupRepository>();
        }
    }
}
