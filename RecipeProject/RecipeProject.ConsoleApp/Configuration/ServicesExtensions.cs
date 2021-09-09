using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RecipeProject.Infra.Data;
using RecipeProject.Infra.Data.Repositories;

namespace RecipeProject.ConsoleApp.Configuration
{
    public class ServicesExtensions
    {
        public static IServiceCollection RegisterServices()
        {
            IServiceCollection services = new ServiceCollection();

            IConfiguration _config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            services.AddDbContext<DataBase>(options =>
            {
                options.UseSqlServer(_config.GetConnectionString("RecipeCS"));
            });

            services.AddScoped<StartUp>();
            services.AddScoped<UserConsole>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;

        }

    }
}
