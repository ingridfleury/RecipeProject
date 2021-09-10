using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeProject.Domain.Model;
using RecipeProject.Infra.Data;
using RecipeProject.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeProject.WebApi.Controllers
{
    [Authorize]
    public class RecipeController : BaseController
    {
        private readonly IRecipeRepository _recipeRepository;

        public RecipeController(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;

        }

        [HttpGet]
        public IEnumerable<Recipe>  GetAll()
        {
            return _recipeRepository.Get();
        }

        [HttpGet("id")]
        public Recipe Get(int id)
        {
            return _recipeRepository.GetById(id);
        }

        [HttpPost]
        public Recipe Add(Recipe recipe)
        {
            return _recipeRepository.Create(recipe);
        }

        [HttpPut]
        public Recipe Update(Recipe recipe)
        {
            return _recipeRepository.Update(recipe);
        }

        [HttpDelete]
        public Recipe Remove(Recipe recipe)
        {
            return _recipeRepository.Delete((recipe));
        }
    }
}
