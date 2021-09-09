using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RecipeProject.Infra.Data;
using System;

namespace RecipeProject.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
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
        }
    }
}
