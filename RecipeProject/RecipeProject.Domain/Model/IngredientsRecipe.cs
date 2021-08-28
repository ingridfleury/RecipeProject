using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Domain.Model
{
    public class IngredientsRecipe
    {

        public int IngredientsRecipeId { get; set; }
        public int IngredientId { get; set; }
        public int MeasureId { get; set; }
        public int RecipeId { get; set; }
        public double Quantity { get; set; }
        public IngredientsRecipe(int ingredientsRecipeId, int ingredientId, int measureId, int recipeId, double quantity)
        {
            IngredientsRecipeId = ingredientsRecipeId;
            IngredientId = ingredientId;
            MeasureId = measureId;
            RecipeId = recipeId;
            Quantity = quantity;
        }
    }
}
