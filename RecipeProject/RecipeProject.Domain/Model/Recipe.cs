using System.Collections.Generic;

namespace RecipeProject.Domain.Model
{
    public class Recipe
    {
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int DificultyId { get; set; }
        public string Name { get; set; }
        public string PreparationMethod { get; set; }
        public IEnumerable<RecipeIngredients> Ingredients { get; set; }
        public Recipe()
        {

        }
        public Recipe(string name, string preparationMethod)
        {

            Name = name;
            PreparationMethod = preparationMethod;
            Ingredients = new List<RecipeIngredients>();

        }

    }
}
