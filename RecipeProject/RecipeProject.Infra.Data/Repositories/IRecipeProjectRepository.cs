using RecipeProject.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeProject.Infra.Data.Repositories
{
    public class RecipeProjectRepository 
    {
        private readonly DataBase context;
        public RecipeProjectRepository(DataBase context)
        {
            this.context = context;
        }

        public IEnumerable<Recipe> Get()
        {
            return context.Recipes.ToList();
        }
        public Recipe Create(Recipe recipe)
        {
            context.Recipes.Add(recipe);
            context.SaveChanges();
            return recipe;
        }

        public Recipe GetById(int id)
        {
            return context.Recipes.FirstOrDefault(x => x.RecipeId == id);
        }

        public Recipe Update(Recipe recipe)
        {
            context.Recipes.Update(recipe);
            context.SaveChanges();
            return recipe;
        }
        public Recipe Delete(Recipe recipe)
        {
            context.Recipes.Remove(recipe);
            context.SaveChanges();
            return recipe;
        }
    }
}
