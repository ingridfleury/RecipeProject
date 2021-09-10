using RecipeProject.Application.Dto;
using RecipeProject.Domain.Model;

namespace RecipeProject.Application.Contracts
{
    public interface IRecipeService : IService<RecipeDto>
    {
    }
}
