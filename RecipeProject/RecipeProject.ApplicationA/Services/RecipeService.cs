using RecipeProject.Domain.Contracts;
using RecipeProject.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeProject.Application.Services
{
    public class RecipeService : IRecipeService
    {
        public RecipeService()
        {

        }
        Recipe IService<Recipe>.Add(Recipe obj)
        {
            throw new NotImplementedException();
        }

        Recipe IService<Recipe>.Delete(Recipe obj)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Recipe> IService<Recipe>.GetAll()
        {
            throw new NotImplementedException();
        }

        Recipe IService<Recipe>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        Recipe IService<Recipe>.Update(Recipe obj)
        {
            throw new NotImplementedException();
        }
    }
}
