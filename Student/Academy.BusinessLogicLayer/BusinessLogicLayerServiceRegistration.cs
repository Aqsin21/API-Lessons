using Academy.BusinessLogicLayer.Services;
using Academy.BusinessLogicLayer.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Academy.BusinessLogicLayer
{
    public static class BusinessLogicLayerServiceRegistration
    {
        public static IServiceCollection RegisterBusinessLogicLayerServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(ICrudService<,,,>) , typeof(CrudManager<,,,>));
            services.AddScoped<IStudentService, StudentManager>();
            services.AddScoped<IGroupService, GroupManager>();
            services.AddAutoMapper(typeof(BusinessLogicLayerServiceRegistration));
            return services;
        }
    }
}
