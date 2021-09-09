using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RecipeProject.Infra.Data;
using RecipeProject.Infra.Data.Repositories;
using System;

namespace RecipeProject.Infra.IoC
{
    public static class DependencyContainer
    {
        public static void AddConfigurations(IServiceCollection services, IConfiguration config)
        {

        }
        public static IServiceCollection RegisterDiServices(IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddDbContext<DataBase>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("RecipeCS"));
            });

            return services;

        }
    }
}
