using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RecipeProject.ConsoleApp.Configuration;
using RecipeProject.Infra.Data;
using System;

namespace RecipeProject.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = ServicesExtensions.RegisterServices();

            var serviceProvider = services.BuildServiceProvider();

            serviceProvider.GetService<StartUp>().Run(args);
        }
    }
}
