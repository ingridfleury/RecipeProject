using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RecipeProject.Infra.IoC;

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


            services.AddScoped<StartUp>();
            services.AddScoped<UserConsole>();

            services.AddOwnConfigurations(_config);

            return services;

        }

    }
}
