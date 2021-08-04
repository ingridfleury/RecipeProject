using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Domain.Model
{
    public class Recipes
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int DificultyId { get; set; }
        public string Title { get; set; }
        public string PreparationMethod { get; set; }
        public List<IngredientsRecipe> MyProperty { get; set; }

    }
}
