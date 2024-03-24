using WMS.Business.Implementations;
using WMS.Business.Interfaces;
using WMS.Business.Profiles;
using WMS.DataAccess.EF.Repositories;
using WMS.DataAccess.Interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace WMS.Business
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(RolProfile));

            services.AddScoped<IRolBs, RolBs>();
            services.AddScoped<IRolRepository, RolRepository>();

            services.AddScoped<ICalisanBs, CalisanBs>();
            services.AddScoped<ICalisanRepository, CalisanRepository>();
        }
    }
}
