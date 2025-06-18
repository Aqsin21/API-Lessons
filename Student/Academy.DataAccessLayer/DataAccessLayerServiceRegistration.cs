using Academy.DataAccessLayer.DataContext;
using Academy.DataAccessLayer.Repositories;
using Academy.DataAccessLayer.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Academy.DataAccessLayer
{
    public static class DataAccessLayerServiceRegistration
    {
       public static IServiceCollection RegisterDataAccessLayerServices(this IServiceCollection services ,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(
               options => options.UseSqlServer(configuration.GetConnectionString("Default")));

            services.AddScoped(typeof(IRepositoryAsync<>), typeof(EfCoreRepository<>));
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<IGroupRepository, GroupRepository>();
            return services;

        }

    }
}
