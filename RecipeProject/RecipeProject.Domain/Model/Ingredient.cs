using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Domain.Model
{
   public class Ingredient
    {

        public int IngredientId { get; set; }
        public string Name { get; set; }
        public int MeasureUnitId { get; set; }
        public MeasureUnit MeasureUnit { get; set; }
        public double Quantity { get; set; }

        public IEnumerable<RecipeIngredients> Recipes { get; set; }
        private Ingredient()
        {

        }

        public Ingredient(string name)
        {            
            Name = name;
        }
    }
}
