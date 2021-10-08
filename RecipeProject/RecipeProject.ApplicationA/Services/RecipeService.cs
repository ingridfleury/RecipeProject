using RecipeProject.Application.Contracts;
using RecipeProject.Application.Dto;
using RecipeProject.Domain.Model;
using RecipeProject.Infra.Data.Repositories;
using System;
using System.Collections.Generic;

namespace RecipeProject.Application.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;

        public RecipeService(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public IEnumerable<RecipeDto> GetAll()
        {
            var list = _recipeRepository.Get();

            var listDtos = new List<RecipeDto>();

            foreach (var recipe in list)
            {
                var recipeDto = new RecipeDto()
                {
                    RecipeId = recipe.RecipeId,
                    UserId = recipe.UserId,
                    Name = recipe.Name,
                    PreparationMethod = recipe.PreparationMethod,
                };

                listDtos.Add(recipeDto);

            }

            return listDtos;

        }
        public RecipeDto GetById(int id)
        {
            Recipe recipe = new()
            {
                RecipeId = id
            };

            Recipe r = _recipeRepository.GetById(id);

            RecipeDto returnRecipe = new()
            {
                RecipeId = r.RecipeId
            };

            return returnRecipe;

        }

        public RecipeDto Add(RecipeDto obj)
        {
            Recipe recipe = new()
            {
                RecipeId = obj.RecipeId,
                CategoryId = obj.CategoryId,
                DificultyId = obj.DificultyId,
                UserId = obj.UserId,
                Name = obj.Name,
               PreparationMethod = obj.PreparationMethod,
            };

            Recipe r = _recipeRepository.Create(recipe);

            RecipeDto returnRecipe = new()
            {
                RecipeId = r.RecipeId
            };

            return returnRecipe;
        }


        public RecipeDto Update(RecipeDto obj)
        {
            Recipe recipe = new()
            {
                RecipeId = obj.RecipeId
            };

            Recipe r = _recipeRepository.Update(recipe);

            RecipeDto returnRecipe = new()
            {
                RecipeId = r.RecipeId
            };

            return returnRecipe;
        }

        public RecipeDto Delete(RecipeDto obj)
        {
            Recipe recipe = new()
            {
                RecipeId = obj.RecipeId
            };

            Recipe r = _recipeRepository.Delete(recipe);

            RecipeDto returnRecipe = new()
            {
                RecipeId = r.RecipeId
            };

            return returnRecipe;
        }
    }
}
