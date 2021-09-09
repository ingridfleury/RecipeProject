using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RecipeProject.Infra.Data;

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

            return services;

        }

    }
}
