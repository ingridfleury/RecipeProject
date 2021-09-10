using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeProject.Application.Contracts;
using RecipeProject.Application.Dto;
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
        private readonly IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;

        }

        [HttpGet]
        public IEnumerable<RecipeDto> GetAll()
        {
            return _recipeService.GetAll();
        }

        [HttpGet("id")]
        public RecipeDto Get(int id)
        {
            return _recipeService.GetById(id);
        }

        [HttpPost]
        public RecipeDto Add(RecipeDto recipe)
        {
            return _recipeService.Add(recipe);
        }

        [HttpPut]
        public RecipeDto Update(RecipeDto recipe)
        {
            return _recipeService.Update(recipe);
        }

        [HttpDelete]
        public RecipeDto Remove(RecipeDto recipe)
        {
            return _recipeService.Delete((recipe));
        }
    }
}
