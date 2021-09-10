using RecipeProject.Domain.Contracts;
using RecipeProject.Domain.Model;
using RecipeProject.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeProject.Application.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;

        public RecipeService(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        IEnumerable<Recipe> IService<Recipe>.GetAll()
        {
            return _recipeRepository.Get();
        }
        Recipe IService<Recipe>.Add(Recipe obj)
        {
            return _recipeRepository.Create(obj);
        }

        Recipe IService<Recipe>.Delete(Recipe obj)
        {
            throw new NotImplementedException();
        }


        Recipe IService<Recipe>.GetById(int id)
        {
            return _recipeRepository.GetById(id);
        }

        Recipe IService<Recipe>.Update(Recipe obj)
        {
            return _recipeRepository.Update(obj);
        }
    }
}
