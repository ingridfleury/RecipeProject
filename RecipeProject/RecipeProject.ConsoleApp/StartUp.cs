using RecipeProject.Domain.Model;
using RecipeProject.Infra.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.ConsoleApp
{
    public class StartUp
    {
        private readonly DataBase context;
        public StartUp(DataBase context)
        {
            this.context = context;
        }

        public void Run(string[] args)
        {
            context.Recipes.Add(new Recipe()
            {
                Name = "Item 01"
            });
            
            context.SaveChanges();

            foreach (var item in context.Recipes)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
