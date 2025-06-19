using Academy.BusinessLogicLayer.Services;
using Academy.BusinessLogicLayer.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;


namespace Academy.BusinessLogicLayer
{
    public static class BusinessLogicLayerServiceRegistration
    {
        public static IServiceCollection RegisterBusinessLogicLayerServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(ICrudService<,,,>) , typeof(CrudManager<,,,>));
            services.AddScoped<IStudentService, StudentManager>();
            services.AddScoped<IGroupService, GroupManager>();
            services.AddScoped<ITeacherService, TeacherManager>();
            services.AddAutoMapper(typeof(BusinessLogicLayerServiceRegistration));
            return services;
        }
    }
}
