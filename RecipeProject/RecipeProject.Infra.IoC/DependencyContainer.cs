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
        public static void AddConsoleConfigurations(this IServiceCollection services, IConfiguration config)
        {
            services.AddCommonConfigurations(config);
        }
        public static void AddApiConfigurations(this IServiceCollection services, IConfiguration config)
        {
            services.AddCommonConfigurations(config);
        }
        public static void AddCommonConfigurations(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DataBase>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("RecipeCS"));
            });

            services.RegisterServices(config);
        }

        public static void  RegisterServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRecipeRepository, RecipeRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();



        }
    }
}
