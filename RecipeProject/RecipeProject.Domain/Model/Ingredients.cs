using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Domain.Model
{
   public class Ingredients
    {

        public int IngredientId { get; set; }
        public string Name { get; set; }

        public Ingredients(int ingredientId, string name)
        {
            IngredientId = ingredientId;
            Name = name;
        }
    }
}
