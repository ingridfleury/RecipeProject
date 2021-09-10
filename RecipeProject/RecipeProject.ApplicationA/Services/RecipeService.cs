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
                    Name = recipe.Name,
                };

                listDtos.Add(recipeDto);

            }

            return listDtos;

        }
        public RecipeDto GetById(int id)
        {
            return _recipeRepository.GetById(obj);

        }

        public RecipeDto Add(RecipeDto obj)
        {
            return _recipeRepository.Create(obj);
        }


        public RecipeDto Update(RecipeDto obj)
        {
            return _recipeRepository.Update(obj);
        }

        public RecipeDto Delete(RecipeDto obj)
        {
            throw new NotImplementedException();
        }
    }
}
