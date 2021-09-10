using RecipeProject.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeProject.Application.Dto
{
    public class RecipeDto
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string PreparationMethod { get; set; }
        public IEnumerable<RecipeIngredients> Ingredients { get; set; }

    }
}
