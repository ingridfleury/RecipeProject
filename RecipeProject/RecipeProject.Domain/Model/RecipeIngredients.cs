using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Domain.Model
{
    public class RecipeIngredients
    {                  

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public RecipeIngredients()
        {

        }

    }
}
