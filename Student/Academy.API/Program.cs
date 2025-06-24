using Academy.BusinessLogicLayer;
using Academy.BusinessLogicLayer.Dtos;
using Academy.DataAccessLayer;
using Academy.DataAccessLayer.DataContext;
using Academy.DataAccessLayer.DataContext.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;


namespace Academy.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.6

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.RegisterDataAccessLayerServices(builder.Configuration);
            builder.Services.RegisterBusinessLogicLayerServices(builder.Configuration);
            builder.Services.Configure<JwtSettings>(options => builder.Configuration.GetSection("JwtSettings"));
            builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
            {
                
                options.Password.RequiredLength = 4;
              
            })
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();



            var app = builder.Build();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
