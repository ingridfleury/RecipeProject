using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Domain.Model
{
    class IngredientsRecipe
    {
        public int IngredientsRecipeId { get; set; }
        public int IngredientId { get; set; }
        public int MeasureId { get; set; }
        public int RecipeId { get; set; }
        public double Quantity { get; set; }
    }
}
